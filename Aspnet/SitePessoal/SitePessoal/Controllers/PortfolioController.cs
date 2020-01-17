using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitePessoal.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                string pathVirtual = "~/Content/Imagens/";
                string pathFisico = Server.MapPath(pathVirtual);

                string[] arquivos = Directory.GetFiles(pathFisico);

                if (arquivos.Count() == 0)
                {
                    throw new FileNotFoundException();
                }

                List<string> imageURLList = new List<string>();
                string nomeArquivo = null;
                string imageUrl = null;

                foreach (var arquivo in arquivos)
                {
                    nomeArquivo = Path.GetFileName(arquivo);
                    imageUrl = Url.Content(pathVirtual + nomeArquivo);

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        imageURLList.Add(imageUrl);
                    }
                }

                if (imageURLList.Count() == 0)
                {
                    throw new FileNotFoundException();
                }

                ViewBag.listaArquivos = imageURLList;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                ViewBag.ErroMsg = "Não foram encontrados arquivos a exibir.";
                ViewBag.listaArquivos = new List<string>();
            }
            
            return View();
        }
    }
}