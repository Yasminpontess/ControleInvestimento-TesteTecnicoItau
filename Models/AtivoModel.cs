using System.ComponentModel.DataAnnotations;

namespace ControleInvestimentosItau.Models
{
    public class Ativo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Ticker { get; set; } // Ex: PETR4, VALE3

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public ICollection<OperacaoModel> Operacoes { get; set; }
    }
}
