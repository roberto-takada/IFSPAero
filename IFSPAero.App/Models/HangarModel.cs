using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    public class HangarModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int IdAeroporto { get; set; }
        public string Aeroporto { get; set; }
    }
}
