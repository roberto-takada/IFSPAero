using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    internal class VooModel
    {
        public int Id { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
        public int IdTipoVoo { get; set; }
        public int IdAeroportoSaida { get; set; }
        public int IdAeroportoChegada { get; set; }
        public int IdCapitao { get; set; }
        public int IdAviao { get; set; }
        public string TipoVoo { get; set; }
        public string NomeAeroportoSaida { get; set; }
        public string NomeAeroportoChegada { get; set; }
        public string NomeCapitao { get; set; }
        public string CodigoAviao { get; set; }
    }
}
