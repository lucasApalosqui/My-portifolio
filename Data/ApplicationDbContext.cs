using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portifolio.Data.Mappings;
using Portifolio.Models;

namespace Portifolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Projects> Projects { get; set; }
        public DbSet<GeneralImages> GeneralImages { get; set; }
        public DbSet<Tools> Tools { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=DESKTOP-BVKU5HC;Database=LucasApalosqui;Trusted_Connection=True;TrustServerCertificate=True");

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToolsMap());
            modelBuilder.ApplyConfiguration(new GeneralImagesMap());
            modelBuilder.ApplyConfiguration(new ProjectsMap());
        }


    }
}
