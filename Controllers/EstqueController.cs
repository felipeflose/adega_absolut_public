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
    public class EstoqueController : Controller
    {

        //Criar uma lista de produtos 
        List<EstoqueViewModel> listEstoque;


        private readonly IConexao _conexao;


        public EstoqueController(IConexao conexao)
        {
            _conexao = conexao;
        }

[Authorize] 
 
        [HttpGet("Estoque")]
        public IActionResult Index()
        {
            using (var conn2 = _conexao.AbrirConexao())
            {
                string sql = "select b.idProduto, b.nome_produto, sum(b.Valor) as valor_unitario, sum(a.quantidade)quantidade, sum(b.Valor)*sum(a.quantidade) valortotal from adega.estoque a inner join adega.produtos b on a.IdProduto = b.IdProduto where a.Tipo_movimentacao = 'e'  group by b.idProduto, b.nome_produto;";
                listEstoque = conn2.Query<EstoqueViewModel>(sql).ToList();
            }

            return View(listEstoque);
        }


        [HttpPost("Estoque/Salvar")]
        public IActionResult Post([FromForm] EstoqueViewModel model)
        {

            string sql = "";
            sql = @"Insert into adega.estoque(IdProduto,  tipo_movimentacao,  quantidade, data_movimentacao) 
                                            values(@IdProduto, @tipo_movimentacao, @quantidade, DATE_ADD(sysdate(3),INTERVAL -3 hour));";


            using (var conne = _conexao.AbrirConexao())
            {
                conne.Execute(sql, model);
            }
            return RedirectToAction("Index");
        }



        [HttpGet("Estoque/Inserir")]
        public IActionResult Inserir()
        {
            return View();
        }


        public IActionResult ListaProduto()
        {
            var listprodutos = new List<EstoqueViewModel>();
            using (var conn_l = _conexao.AbrirConexao())
            {
                string sql = "select distinct b.nome_produto Adega.Produtos b";
                listEstoque = conn_l.Query<EstoqueViewModel>(sql).ToList();
            }

            return View(listprodutos);
        }




    }
}