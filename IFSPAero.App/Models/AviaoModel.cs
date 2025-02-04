using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    public class AviaoModel
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public byte[] Imagem { get; set; }
        public int Situacao { get; set; }
        public int IdCompanhia { get; set; }
        public string Companhia { get; set; }
    }
}
