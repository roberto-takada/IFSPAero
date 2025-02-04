using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPAero.Repository.Mapping
{
    public class CompanhiaMap : IEntityTypeConfiguration<Companhia>
    {
        public void Configure(EntityTypeBuilder<Companhia> builder)
        {
            builder.ToTable("Companhia");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}

