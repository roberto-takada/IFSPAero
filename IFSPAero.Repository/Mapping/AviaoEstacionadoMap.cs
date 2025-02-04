using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class AviaoEstacionadoMap : IEntityTypeConfiguration<AviaoEstacionado>
    {
        public void Configure(EntityTypeBuilder<AviaoEstacionado> builder)
        {
            builder.ToTable("AviaoEstacionado");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.ComecoEstacionamento)
                .IsRequired();
            builder.Property(prop => prop.FimEstacionamento);
            builder.Property(prop => prop.DuracaoEstacionamento)
                .IsRequired();
            builder.HasOne(prop => prop.Aviao);
            builder.HasOne(prop => prop.Hangar);
        }
    }
}

