using System;
using System.Collections.Generic;
using AppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using AppWeb.Repositorio;
using Dapper;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace AppWeb.Controllers
{
    public class VendasController : Controller
    {

        //Criar uma lista de produtos 
        List<VendasViewModel> listVendas;
        private readonly IConexao _conexao;

        //Construtor da classe produtoController
        public VendasController(IConexao conexao)
        {
            _conexao = conexao;
        }


        [Authorize] 
        [HttpGet("Vendas")]
        public IActionResult Index()
        {
            using (var conn2 = _conexao.AbrirConexao())
            {
                // string sql = "select * from adega.pedidos a inner join adega.clientes b on a.fkCliente = b.idCliente";
                string sql = "select * from adega.vendas a left join adega.produtos b on a.idProduto = b.idProduto order by a.data_Pedido desc";
                listVendas = conn2.Query<VendasViewModel>(sql).ToList();
            }

            return View(listVendas);
        }


        [HttpPost("Vendas/Salvar")]
        public IActionResult Post([FromForm] VendasViewModel model)
        {


            string sql = "Insert into adega.vendas (IdProduto,  quantidade,  tipo_pagamento,  data_pedido, valortotal, IdCliente) values(@IdProduto, @quantidade, @tipo_pagamento,  DATE_ADD(sysdate(3),INTERVAL -3 hour), -1, @IdCliente); update adega.vendas left join adega.produtos b on adega.vendas.idProduto = b.IdProduto SET adega.vendas.valortotal = adega.vendas.quantidade * b.valor ;";

            using (var conne = _conexao.AbrirConexao())
            {
                conne.Execute(sql, model);
            }
            return RedirectToAction("Index");
        }


        [HttpGet("Vendas/Criar")]
        public IActionResult Criar()
        {
            var listProdutos = new List<ProdutoViewModel>();
            using (var conn = _conexao.AbrirConexao())
            {
                string sql = "SELECT * FROM adega.produtos;";
                listProdutos = conn.Query<ProdutoViewModel>(sql).ToList();
            }
            var venda = new VendasViewModel
            {
                produtos = listProdutos
            };
            return View(venda);
        }



    }
}