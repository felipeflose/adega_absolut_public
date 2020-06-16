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
    public class ProdutoController : Controller
    {

        //Criar uma lista de produtos 
        List<ProdutoViewModel> listProdutos;
        private readonly IConexao _conexao;

        //Construtor da classe produtoController
        public ProdutoController(IConexao conexao)
        {
            _conexao = conexao;
        }


        
        [Authorize] 
        [HttpGet("Produtos")]
        public IActionResult Index()
        {
            using (var conn = _conexao.AbrirConexao())
            {
                string sql = "SELECT * FROM adega.produtos;";
                listProdutos = conn.Query<ProdutoViewModel>(sql).ToList();
            }

            return View(listProdutos);
        }

        [HttpGet("Produtos/Editar/{IdProduto}")]
        public IActionResult Editar(int IdProduto)
        {
            ProdutoViewModel produto;
            using (var conn_f = _conexao.AbrirConexao())

            {

                var sql_edit = $"select * from adega.Produtos where IdProduto = {IdProduto} ;";
                produto = conn_f.QueryFirst<ProdutoViewModel>(sql_edit);

            }
            return View(produto);
        }
        
        [HttpPost("Produto/Salvar")]
        public IActionResult Post([FromForm] ProdutoViewModel model)
        {
            string sql = "";
            if (model.IdProduto != 0)
            {
                if (model.Classificacao_idade == "Sim")
                {
                    sql = @"Update adega.produtos set 
                        nome_produto = @nome_produto, 
                        valor =  @valor,
                        validade_produto = @validade_produto,   
                        Classificacao_idade = 'Sim',
                        categoria = @categoria,
                        marca = @marca
                        where idProduto = @IdProduto";
                }

                else
                {
                    sql = @"Update adega.produtos set 
                        nome_produto = @nome_produto, 
                        valor =  @valor,
                        validade_produto = @validade_produto,   
                        Classificacao_idade = 'Não',
                        categoria = @categoria,
                        marca = @marca
                        where idProduto = @IdProduto";
                }

            }
            else
            {
                if (model.Classificacao_idade == "Sim")
                {
                    sql = @"Insert into adega.produtos(nome_produto,  valor,  validade_produto,   Classificacao_idade, categoria, marca) 
                                            values(@nome_produto, @valor, @validade_produto, 'Sim', @categoria, @marca);";
                }

                else
                {
                    sql = @"Insert into adega.produtos(nome_produto,  valor,  validade_produto,   Classificacao_idade, categoria, marca) 
                                            values(@nome_produto, @valor, @validade_produto, 'Não', @categoria, @marca);";
                }

            }

            using (var conne = _conexao.AbrirConexao())
            {
                conne.Execute(sql, model);
            }
            return RedirectToAction("Index");
        }


        [HttpGet("Produtos/deletar/{IdProduto}")]
        public IActionResult Deletar(int IdProduto)

        {

            using (var conn2 = _conexao.AbrirConexao())

            {
                var produto_delete = $" delete FROM adega.Produtos where idProduto = {IdProduto} ; ";
                conn2.Execute(produto_delete);
            }

            return RedirectToAction("Index");
        }

        [HttpGet("Produtos/Criar")]
        public IActionResult Criar()
        {
            return View();
        }





    }
}