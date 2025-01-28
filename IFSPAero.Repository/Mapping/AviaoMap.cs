using Microsoft.EntityFrameworkCore;
using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class AviaoMap : IEntityTypeConfiguration<Aviao>
    {
        public void Configure(EntityTypeBuilder<Aviao> builder)
        {
            builder.ToTable("Aviao");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Modelo)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Codigo)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Situacao)
                .IsRequired()
                .HasColumnType("integer");
            builder.Property(prop => prop.Imagem)
                .IsRequired()
                .HasColumnType("mediumblob");
            builder.HasOne(prop => prop.Companhia);
        }
    }
}

