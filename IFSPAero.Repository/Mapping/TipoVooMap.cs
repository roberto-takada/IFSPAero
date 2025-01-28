using Microsoft.EntityFrameworkCore;
using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class TipoVooMap : IEntityTypeConfiguration<TipoVoo>
    {
        public void Configure(EntityTypeBuilder<TipoVoo> builder)
        {
            builder.ToTable("TipoVoo");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Tipo)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}
