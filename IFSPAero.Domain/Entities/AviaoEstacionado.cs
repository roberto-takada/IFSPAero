using System.Runtime.InteropServices.JavaScript;
using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class AviaoEstacionado : BaseEntity<int>
{
    public AviaoEstacionado()
    {
        
    }

    public AviaoEstacionado(int id, Aviao aviao, Hangar hangar, DateTime comecoEstacionamento, string duracaoEstacionamento, DateTime fimEstacionamento)
    {

        Id = id;
        Aviao = aviao;
        Hangar = hangar;
        ComecoEstacionamento = comecoEstacionamento;
        DuracaoEstacionamento = duracaoEstacionamento;
        FimEstacionamento = fimEstacionamento;

    }
    
    public Aviao? Aviao { get; set; }
    public Hangar? Hangar { get; set; }
    public DateTime? ComecoEstacionamento { get; set; }
    public string? DuracaoEstacionamento { get; set; }
    public DateTime? FimEstacionamento { get; set; }
}