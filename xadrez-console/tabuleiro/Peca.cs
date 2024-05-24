﻿namespace tabuleiro;

public class Peca
{
public Posicao posicao { get; set; }
public Cor cor { get; set; }
public int qtdeMovimento { get; set; }
public Tabuleiro tab { get; set; }

public Peca (Posicao posicao, Cor cor, Tabuleiro tab){
 this.posicao = posicao;
 this.cor = cor;
 this.tab = tab;
 this.qtdeMovimento = 0;
} 
}
