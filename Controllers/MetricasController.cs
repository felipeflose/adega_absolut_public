using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppWeb.Models;
using AppWeb.Repositorio;
using Dapper;
using Microsoft.AspNetCore.Authorization;

namespace AppWeb.Controllers
{
    public class MetricasController : Controller
    
    {

          List<MetricasController> listaVenda;


      private readonly IConexao _conexao; 

       
        public MetricasController(IConexao conexao)
        {
             _conexao = conexao;
        }

[Authorize] 
        public IActionResult Index()
        {
            
        using(var conn2  = _conexao.AbrirConexao())
            {
                // string sql = "select * from adega.pedidos a inner join adega.clientes b on a.fkCliente = b.idCliente";
                string sql = "select count(distinct idProduto) quantidade from adega.Produtos";
                listaVenda = conn2.Query<MetricasController>(sql).ToList();
            }
            
            return View(listaVenda);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
