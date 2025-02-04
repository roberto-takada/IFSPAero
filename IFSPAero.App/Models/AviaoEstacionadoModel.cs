using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    public class AviaoEstacionadoModel
    {
        public int Id { get; set; }
        public DateTime ComecoEstacionamento { get; set; }
        public DateTime FimEstacionamento {get;set; }
        public string DuracaoEstacionamento { get; set; }
        public int IdAviao { get; set; }
        public string CodigoAviao { get; set; }
        public int IdHangar { get; set; }
        public string CodigoHangar { get; set; }
    }
}
