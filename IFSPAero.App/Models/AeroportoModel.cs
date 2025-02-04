using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    public class AeroportoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
    }
}
