using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPAero.App.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento {  get; set; }
        public int IdFuncao { get; set; }
        public string Funcao { get; set; }
        public int IdCompanhia { get; set; }
        public string Companhia { get; set; }
    }
}
