﻿using ControleInvestimentosItau.Models;

namespace ControleInvestimentosItau.Models;
public class Ativo
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty; // Ex: ITSA3, KDIF11
    public string Nome { get; set; } = string.Empty;

    public ICollection<Operacao> Operacoes { get; set; } = new List<Operacao>();
    public ICollection<Cotacao> Cotacoes { get; set; } = new List<Cotacao>();
    public ICollection<Posicao> Posicoes { get; set; } = new List<Posicao>();
}
