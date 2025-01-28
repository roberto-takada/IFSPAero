using IFSPAero.Domain.Base;
namespace IFSPAero.Domain.Entities;

public class Companhia : BaseEntity<int>
{
    public Companhia()
    {
        
    }

    public Companhia(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
    
    public string? Nome { get; set; }
}