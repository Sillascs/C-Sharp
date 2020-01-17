using SitePessoal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
                if(string.IsNullOrEmpty(contato.Mail)
                       || string.IsNullOrEmpty(contato.Name)
                       || string.IsNullOrEmpty(contato.Message))
                {
                    throw new ValidationException("Favor preencher todo formulário");
                }

                var pathVirtual = "~/contatos.txt";
                var pathFisico = Server.MapPath(pathVirtual);

                using(var sw = new StreamWriter(pathFisico, true))
                {
                    sw.Write(contato.Name + ";");
                    sw.Write(contato.Mail + ";");
                    sw.Write(contato.Message + ";");
                    sw.Write(DateTime.Now + ";\n");
                }

                ViewBag.Concluido = true;
            }
            catch (ValidationException ve)
            {
                ViewBag.ErrorMsg = ve.Message;
                ViewBag.Concluido = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ViewBag.ErrorMsg = "Ocorreu erro ao salvar arquivo, entre em contato com o administrador do sistema.";
                ViewBag.Concluido = false;
            }
            
            return View("Index");
        }
    }
}