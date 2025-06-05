using System.ComponentModel.DataAnnotations;

namespace ControleInvestimentosItau.Models
{
    public class Investidor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<OperacaoModel> Operacoes { get; set; }
    }
}
