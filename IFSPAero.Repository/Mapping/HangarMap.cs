using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class HangarMap : IEntityTypeConfiguration<Hangar>
    {
        public void Configure(EntityTypeBuilder<Hangar> builder)
        {
            builder.ToTable("Hangar");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Codigo).IsRequired().HasColumnType("varchar(10)");
            builder.HasOne(prop => prop.Aeroporto);
        }
    } 
}

