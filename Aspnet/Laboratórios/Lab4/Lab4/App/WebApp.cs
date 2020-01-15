using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Lab4.App
{
    public class WebApp
    {
        private static string comentarioArquivo
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/comentarios.txt");
            }
        }

        public static void ComentarioIncluir(string nome, string comentario)
        {
            using (var writer = new StreamWriter(comentarioArquivo, true, Encoding.UTF8))
            {
                writer.WriteLine("{0:dd/MM/yyyy} - {0:HH:mm:ss}", DateTime.Now);

                writer.WriteLine("{0}: {1}\r\n", nome, comentario);

            }        }        public static string ComentariosObter()
        {
            string texto = string.Empty;

            if (File.Exists(comentarioArquivo))
            {
                using (var reader = new StreamReader(comentarioArquivo))
                {
                    texto = reader.ReadToEnd();                    
                }
            }
            return texto;
        }
    }
}