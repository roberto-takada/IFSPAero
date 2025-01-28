using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class Hangar : BaseEntity<int>
{
    public Hangar()
    {
        
    }

    public Hangar(int id, string codigo, Aeroporto? aeroporto)
    {
        Id = id;
        Codigo = codigo;
        Aeroporto = aeroporto;
    }
    
    public string? Codigo { get; set; }
    public Aeroporto? Aeroporto { get; set; }
}