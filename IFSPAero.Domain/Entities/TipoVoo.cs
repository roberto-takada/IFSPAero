using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class TipoVoo : BaseEntity<int>
{
    public TipoVoo()
    {
        
    }

    public TipoVoo(int id, string tipo)
    {
        Id = id;
        Tipo = tipo;
    }
    
    public string? Tipo { get; set; }
}