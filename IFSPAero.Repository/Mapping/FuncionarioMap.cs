using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Documento)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.HasOne(prop => prop.Funcao);
            builder.HasOne(prop => prop.Companhia);
        }
    }
}

