using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Models;

namespace Portifolio.Data.Mappings
{
    public class ToolsMap : IEntityTypeConfiguration<Tools>
    {
        public void Configure(EntityTypeBuilder<Tools> builder)
        {
            builder.ToTable("Tools");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.HasMany(x => x.Projects)
                .WithMany(x => x.Tools)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectTools",
                        tools => tools.HasOne<Projects>()
                            .WithMany()
                            .HasForeignKey("ProjectId")
                            .HasConstraintName("FK_ProjectTools_ProjectId")
                            .OnDelete(DeleteBehavior.Cascade),
                        project => project.HasOne<Tools>()
                            .WithMany()
                            .HasForeignKey("ToolsId")
                            .HasConstraintName("FK_ProjectTools_ToolsId")
                            .OnDelete(DeleteBehavior.Cascade)
                );

        }
    }
}
