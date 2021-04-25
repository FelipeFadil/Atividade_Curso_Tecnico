using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using UC04_Atividade_2_Felipe_Fadil.Models;

namespace UC04_Atividade_2_Felipe_Fadil.Controllers
{
    public class PacotesTuristicosController : Controller
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

                return RedirectToAction("Cadastro");

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

            PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
            List<PacotesTuristicos> listagem = ptr.Listar();
            return View(listagem);
        }

        public IActionResult Cadastro(){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");
            
            ViewBag.IdUsuario = HttpContext.Session.GetInt32("IdUsuario");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(PacotesTuristicos pacotesTuristicos){

            PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
            ptr.Inserir(pacotesTuristicos);
            ViewBag.Mensagem = "Pacote Turístico cadastrado com sucesso!";
            ModelState.Clear();
            return View();
        }

        public IActionResult Remover(int id){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
            PacotesTuristicos pacotesTuristicos = ptr.BuscarPorId(id);
            ptr.Deletar(pacotesTuristicos);
            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
            PacotesTuristicos pacotesTuristicos = ptr.BuscarPorId(id);
            return View(pacotesTuristicos);
        }

        [HttpPost]
        public IActionResult Editar(PacotesTuristicos pacotesTuristicos){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
            ptr.Atualizar(pacotesTuristicos);
            return RedirectToAction("Lista");
        }
    }
}