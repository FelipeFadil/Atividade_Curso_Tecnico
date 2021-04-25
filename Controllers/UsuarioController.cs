using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using UC04_Atividade_2_Felipe_Fadil.Models;

namespace UC04_Atividade_2_Felipe_Fadil.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario){

            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioSessao = ur.ValidarLogin(usuario);

            if (usuarioSessao != null){
                ViewBag.Mensagem = "Você está logado!";

                //Registrar na sessao os dados retornados na validacao
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.Id);
                HttpContext.Session.SetString("NomeUsuario", usuarioSessao.Nome);

                return RedirectToAction("Lista");

            } else{
                ViewBag.Mensagem = "Falha no login!";
                return View();
            }
        }

        public IActionResult Logout(){
            //Limpar dados de uma sessao
            HttpContext.Session.Clear();
            return View("Login");

        }


        public IActionResult Lista(){
            
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> listagem = ur.Listar();
            return View(listagem);
        }

        public IActionResult Cadastro(){          
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario){

            UsuarioRepository ur = new UsuarioRepository();
            ur.Inserir(usuario);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            ModelState.Clear();
            return View();
        }

        public IActionResult Remover(int id){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.BuscarPorId(id);
            ur.Deletar(usuario);
            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.BuscarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository ur = new UsuarioRepository();
            ur.Atualizar(usuario);
            return RedirectToAction("Lista");
        }
    }
}