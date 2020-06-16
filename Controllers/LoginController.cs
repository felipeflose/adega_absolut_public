using AppWeb.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using AppWeb.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace adega.Controllers
{
    public class LoginController : Controller
    {
        
        public readonly IConexao _conexao;


        public LoginController(IConexao conexao)
        {
            _conexao = conexao;
        }


      [HttpGet]
    
        public ActionResult UsuarioLogin()
        {
            return View();
        }

[HttpPost]
        public  async Task<ActionResult> UsuarioLogin([FromForm] UsuarioViewModel usuario)
        {
            UsuarioViewModel usuarioViewModel = null ;
 
             using (var conn = _conexao.AbrirConexao())
            {
                var querySQL = $"SELECT * FROM adega.usuario where login = '{usuario.Login}' and senha = '{usuario.Senha}';";
                usuarioViewModel = conn.QueryFirst<UsuarioViewModel>(querySQL);
            }
 
            if (usuarioViewModel.Login != null)
            {
                var userClaims = new List<Claim>()
                {
                    //define o cookie
                    new Claim(ClaimTypes.Name, usuarioViewModel.Login),
                    new Claim(ClaimTypes.Email, usuarioViewModel.Email),
                };
 
                var minhaIdentity = new ClaimsIdentity(userClaims, "Usuario");
 
                var userPrincipal = new ClaimsPrincipal(new[] { minhaIdentity });
 
                //cria o cookie
               await HttpContext.SignInAsync(userPrincipal);
 
                return RedirectToAction("Index", "Home");
            }
 
            ViewBag.Message = "Credenciais inválidas...";
 
            return View(usuarioViewModel);
        }

         public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}