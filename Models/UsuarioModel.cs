﻿using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal CorretagemPercentual { get; set; }

    public ICollection<Operacao> Operacoes { get; set; } = new List<Operacao>();
    public ICollection<Posicao> Posicoes { get; set; } = new List<Posicao>();
}
