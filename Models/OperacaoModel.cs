using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Models;

public enum TipoOperacao
{
    Compra,
    Venda
}

public class Operacao
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public int AtivoId { get; set; }
    public Ativo Ativo { get; set; }

    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public TipoOperacao TipoOperacao { get; set; }
    public decimal Corretagem { get; set; }
    public DateTime DataHora { get; set; }
}
