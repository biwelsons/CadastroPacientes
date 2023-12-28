using Microsoft.EntityFrameworkCore;
using CadastroPacientes.Models;

namespace CadastroPacientes.Repositories
{
    public class AppDbContext : DbContext
    {
        // Define a tabela CadastroPacientes do banco de dados como DbSet
        public DbSet<CadastroPacientes> CadastroPacientes { get; set; }

        // Define as opções de DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CadastroPacientes>(entity =>
            {
                entity.ToTable("cadastropacientes"); 

                entity.Property(c => c.Estado)
                    .HasMaxLength(2)
                    .IsRequired();
                
            });
        }
    }
}
