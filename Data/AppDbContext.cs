using Microsoft.EntityFrameworkCore;
using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Properties.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<OperacaoModel> Operacoes { get; set; }
        public DbSet<Investidor> Investidores { get; set; }

        // Caso queira definir o nome das tabelas no banco
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ativo>().ToTable("Ativos");
            modelBuilder.Entity<OperacaoModel>().ToTable("Operacoes");
            modelBuilder.Entity<Investidor>().ToTable("Investidores");
        }
    }
}
