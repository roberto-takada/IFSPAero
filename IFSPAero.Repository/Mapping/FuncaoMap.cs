using Microsoft.EntityFrameworkCore;
using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    
    public class FuncaoMap: IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.ToTable("Funcao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeFuncao)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }    
}
