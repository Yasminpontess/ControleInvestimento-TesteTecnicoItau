using Microsoft.EntityFrameworkCore;
using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Properties.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Ativo> Ativos => Set<Ativo>();
        public DbSet<Operacao> Operacoes => Set<Operacao>();
        public DbSet<Cotacao> Cotacoes => Set<Cotacao>();
        public DbSet<Posicao> Posicoes => Set<Posicao>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Ativo>().ToTable("ativos");
            modelBuilder.Entity<Operacao>().ToTable("operacoes");
            modelBuilder.Entity<Cotacao>().ToTable("cotacoes");
            modelBuilder.Entity<Posicao>().ToTable("posicoes");
        }
    }
}
