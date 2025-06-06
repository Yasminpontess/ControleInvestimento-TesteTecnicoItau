using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Models
{
    public class Posicao
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int AtivoId { get; set; }
        public Ativo Ativo { get; set; }

        public int Quantidade { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal PnL { get; set; } 
    }

}
