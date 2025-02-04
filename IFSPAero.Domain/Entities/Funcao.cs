using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class Funcao : BaseEntity<int>
{
    public Funcao()
    {
        
    }

    public Funcao(int id, string nomeFuncao)
    {
        Id = id;
        NomeFuncao = nomeFuncao;
    }
    
    public string? NomeFuncao { get; set; }
}