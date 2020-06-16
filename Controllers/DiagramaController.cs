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
    public class DiagramaController : Controller
    {
        
[Authorize] 
 [HttpGet("Diagrama")]
        public IActionResult Index()
        {
            return View();
        }

[HttpGet("Diagrama/Telas")]
        public IActionResult Telas()
        {
            return View();
        }

[HttpGet("Diagrama/Banco")]
        public IActionResult Banco()
        {
            return View();
        }

[HttpGet("Diagrama/Docx")]
        public IActionResult Docx()
        {
            return View();
        }




    }
}
