using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Models;

namespace Portifolio.Data.Mappings
{
    public class ProjectsMap : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("TEXT")
                .IsRequired();

            builder.Property(x => x.LinkRepository)
                .HasColumnName("LinkRepository")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256);

            builder.Property(x => x.PageName)
                .HasColumnName("PageName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256);
                


        }
    }
}
