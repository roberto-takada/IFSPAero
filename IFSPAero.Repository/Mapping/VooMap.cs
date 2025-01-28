using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    
    public class VooMap : IEntityTypeConfiguration<Voo>
    {
        public void Configure(EntityTypeBuilder<Voo> builder)
        {
            builder.ToTable("Voo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.DataSaida)
                .IsRequired();
            builder.Property(prop => prop.DataChegada)
                .IsRequired();
            builder.HasOne(prop => prop.Aviao);
            builder.HasOne(prop => prop.Capitao);
            builder.HasOne(prop => prop.TipoVoo);
            builder.HasOne(prop => prop.AeroportoChegada);
            builder.HasOne(prop => prop.AeroportoSaida);
        }
    }
}
