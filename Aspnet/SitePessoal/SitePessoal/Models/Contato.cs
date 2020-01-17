using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitePessoal.Models
{
    public class Contato
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
        public DateTime Data { get; set; }
    }
}