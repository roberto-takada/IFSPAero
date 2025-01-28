using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class Funcionario : BaseEntity<int>
{
    public Funcionario()
    {
        
    }

    public Funcionario(int id, string nome, string documento, Funcao funcao, Companhia? companhia)
    {
        Id = id;
        Nome = nome;
        Documento = documento;
        Funcao = funcao;
        Companhia = companhia;

    }
    
    public string? Nome { get; set; }
    public string? Documento { get; set; }
    public Companhia? Companhia { get; set; }
    public Funcao? Funcao { get; set; }
}