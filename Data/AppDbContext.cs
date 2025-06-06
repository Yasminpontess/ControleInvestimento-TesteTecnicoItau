using Microsoft.EntityFrameworkCore;
using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Properties.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Investidor> Investidores { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ativo>().ToTable("Ativos");
            modelBuilder.Entity<Operacao>().ToTable("Operacoes");
            modelBuilder.Entity<Investidor>().ToTable("Investidores");
        }
    }
}
