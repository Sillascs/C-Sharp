using SiteEmpresarial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteEmpresarial.DB;

namespace SiteEmpresarial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuemSomos()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contato(Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ValidationException("favor preencher todos os campos obrigatórios");
                }

                using (var db = new SiteEmpresarialDBContext())
                {
                    var existecontato = db.Contatos.Where(c => c.Email == contato.Email && c.Nome == contato.Nome).Any();

                    if(existecontato)
                    {
                        throw new ValidationException("Contato inserido já cadastrado, tente outras informações");
                    }

                    db.Contatos.Add(contato);
                    db.SaveChanges();
                }

                return View("ContatoSucesso");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(contato);
            }
        }
    }
}