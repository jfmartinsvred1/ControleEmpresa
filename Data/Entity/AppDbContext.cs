using ControleEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmpresa.Data.Entity
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts):base(opts)
        {
            
        }

        public DbSet<Setor> Setores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ponto> Pontos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ponto>()
                .Property(p => p.Entrada)
                .HasColumnName("Entrada")
                .HasColumnType("time");
            modelBuilder.Entity<Ponto>()
                .Property(p => p.Saida)
                .HasColumnName("Saida")
                .HasColumnType("time");
        }
    }
}
