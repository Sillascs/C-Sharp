using SitePessoal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitePessoal.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Concluido = false;

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Contato contato)
        {
            try
            {
                if (string.IsNullOrEmpty(contato.Nome) ||
                    string.IsNullOrEmpty(contato.Email) ||
                    string.IsNullOrEmpty(contato.Mensagem))
                {
                    throw new ArgumentException("Favor preencher todos os campos");
                }
                ViewBag.Concluido = true;
            }
            catch(Exception ex)
            {
                ViewBag.ErroMsg = ex.Message;
                ViewBag.Concluido = false;
            }
            

            return View("Index");
        }


    }
}