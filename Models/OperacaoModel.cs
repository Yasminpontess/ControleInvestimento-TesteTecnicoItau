using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleInvestimentosItau.Models
{
    public class OperacaoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public TipoOperacao Tipo { get; set; } // Compra ou Venda

        // Relacionamentos
        public int InvestidorId { get; set; }
        public Investidor Investidor { get; set; }

        public int AtivoId { get; set; }
        public Ativo Ativo { get; set; }
    }

    public enum TipoOperacao
    {
        Compra,
        Venda
    }
}
