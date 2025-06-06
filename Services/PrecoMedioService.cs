using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Services
{
    public class PrecoMedioService
    {
        public decimal CalcularPrecoMedio(IEnumerable<Operacao> operacoesCompra)
        {
            if (!operacoesCompra.Any()) throw new ArgumentException("Lista de operações vazia.");

            decimal totalInvestido = 0;
            int totalQuantidade = 0;

            foreach (var op in operacoesCompra)
            {
                if (op.TipoOperacao != TipoOperacao.Compra) continue;
                if (op.Quantidade <= 0) throw new ArgumentException("Quantidade inválida.");

                var valorTotal = (op.PrecoUnitario * op.Quantidade) + op.Corretagem;
                totalInvestido += valorTotal;
                totalQuantidade += op.Quantidade;
            }

            if (totalQuantidade == 0) throw new ArgumentException("Quantidade total não pode ser zero.");

            return totalInvestido / totalQuantidade;
        }
    }

}
