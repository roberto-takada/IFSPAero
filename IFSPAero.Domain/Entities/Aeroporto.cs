using IFSPAero.Domain.Base;
namespace IFSPAero.Domain.Entities;

public class Aeroporto : BaseEntity<int>
{
    public Aeroporto()
    {
        
    }

    public Aeroporto(int id, string nome, string codigo, string cidade, string pais)
    {
        Id = id;
        Nome = nome;
        Codigo = codigo;
        Cidade = cidade;
        Pais = pais;
    }
    
    public string? Nome { get; set; }
    public string? Codigo { get; set; }
    public string? Cidade { get; set; }
    public string? Pais { get; set; }
}