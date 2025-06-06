    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Models
    {
        public class Investidor
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; } = string.Empty;

            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required]
            [Column(TypeName = "decimal(5,2)")]
            public decimal CorretagemPercentual { get; set; } // Representa a % da corretagem ex: 0.50%

            // Relacionamento
            public ICollection<Operacao> Operacoes { get; set; } = new List<Operacao>();
        }
    }


