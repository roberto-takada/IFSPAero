using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class AeroportoMap : IEntityTypeConfiguration<Aeroporto>
    {
        public void Configure(EntityTypeBuilder<Aeroporto> builder)
        {
            builder.ToTable("Aeroporto");
            
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Codigo)
                .IsRequired()
                .HasColumnType("varchar(10)");
            builder.Property(prop => prop.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Pais)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}

