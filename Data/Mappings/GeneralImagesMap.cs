using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Models;

namespace Portifolio.Data.Mappings
{
    public class GeneralImagesMap : IEntityTypeConfiguration<GeneralImages>
    {
        public void Configure(EntityTypeBuilder<GeneralImages> builder)
        {
            builder.ToTable("General_Images");

            builder.HasKey(x => x.id);

            builder.Property(x => x.id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Url)
                .HasColumnName("Url")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.HasOne(x => x.Projects)
                .WithMany(x => x.Images)
                .HasConstraintName("FK_Projects_Images")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
