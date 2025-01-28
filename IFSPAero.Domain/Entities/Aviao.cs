using System.Reflection.Metadata;
using IFSPAero.Domain.Base;

namespace IFSPAero.Domain.Entities;

public class Aviao : BaseEntity<int>
{
    public Aviao()
    {
        
    }
    
    public Aviao(int id, string modelo, int situacao, string codigo, byte[] imagem, Companhia? companhia)
    {
        Id = id;
        Modelo = modelo;
        Imagem = imagem;
        Situacao = situacao;
        Codigo = codigo;
        Companhia = companhia;

    }
    
    public string? Modelo { get; set; }
    public byte[]? Imagem { get; set; }
    public int? Situacao { get; set; }
    public string? Codigo { get; set; }
    public Companhia? Companhia { get; set; }
}