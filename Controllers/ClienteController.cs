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
    public class ClienteController : Controller
    {

        //Criar uma lista de produtos 
        private readonly IConexao _conexao; 

        //Construtor da classe produtoController
        public ClienteController(IConexao conexao)
        {
             _conexao = conexao;
        }

        [HttpGet("Clientes")]
        public IActionResult Index()
        {
            var listClientes = new List<ClienteViewModel>();
            using(var conn1  = _conexao.AbrirConexao()) 
            {
                 string sql = "SELECT * FROM clientes";
                 listClientes = conn1.Query<ClienteViewModel>(sql).ToList();
            }
            
            return View(listClientes);
        }

        [HttpGet("Cliente/Inserir")]
        public IActionResult Inserir()
        {
            return View();
        }


        [HttpGet("Cliente/Editar/{IdCliente}")]
        public IActionResult Editar(int idcliente)
        {
           ClienteViewModel clientes_edit;
           using (var edit1 = _conexao.AbrirConexao())
           {
                

                var edit_cliente = $"Select * from clientes where idcliente = {idcliente}";

               clientes_edit = edit1.QueryFirst<ClienteViewModel>(edit_cliente);

           }
           
           return View(clientes_edit);
           
        }

        [HttpGet("Cliente/deletar/{IdCliente}")]
        public IActionResult Deletar(int idCliente)

        {

            using (var conn2 = _conexao.AbrirConexao())

            {
                var cliente_delete = $" delete FROM clientes where IdCliente = {idCliente} ; ";
                conn2.Execute(cliente_delete);
            }

            return RedirectToAction("Index");
        }

        [HttpPost("Cliente/Salvar")]
        public IActionResult Post([FromForm] ClienteViewModel model)
        {

            var sql = @"Insert into clientes (nome, cpf, dtNasc, telefone, cep, numCasa, dtCadastro)
                                            values(@Nome, @Cpf, @dtNasc, @Telefone, @CEP, @numCasa, now());";


            using (var conne = _conexao.AbrirConexao())
            {
                conne.Execute(sql, model);
            }
            return RedirectToAction("Index");
        }


        [HttpPost("Cliente/EditarCliente")]
        public IActionResult EditarCliente([FromForm] ClienteViewModel model)
        {
            using (var edit1 = _conexao.AbrirConexao())
            {


                //var edit_cliente = $"update * from clientes where idcliente = {idcliente}";

                var update_cliente = $"Update clientes set Nome = @Nome, Cpf =  @Cpf, dtNasc = @dtNasc, Telefone = @Telefone, CEP = @CEP, numCasa = @numCasa where idcliente = {model.IdCliente}";

                edit1.Execute(update_cliente, model);

            }

            return RedirectToAction("Index");

        }


    }
}