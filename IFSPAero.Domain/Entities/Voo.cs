using System.Runtime.InteropServices.JavaScript;
using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class Voo : BaseEntity<int>
{
    public Voo()
    {
        
    }

    public Voo(int id, TipoVoo tipoVoo, Aeroporto aeroportoSaida, Aeroporto aeroportoChegada, Funcionario capitao,
        Aviao aviao, DateTime dataSaida, DateTime dataChegada)
    {
        Id = id;
        TipoVoo = tipoVoo;
        AeroportoChegada = aeroportoChegada;
        AeroportoSaida = aeroportoSaida;
        Capitao = capitao;
        Aviao = aviao;
        DataSaida = dataSaida;
        DataChegada = dataChegada;
    }
    
    public TipoVoo? TipoVoo { get; set; }
    public Aeroporto? AeroportoSaida { get; set; }
    public Aeroporto? AeroportoChegada { get; set; }
    public Funcionario? Capitao { get; set; }
    public Aviao? Aviao { get; set; }
    public DateTime? DataSaida { get; set; }
    public DateTime? DataChegada { get; set; }
    
    
}