﻿namespace tabuleiro;

public class Peca
{
public Posicao posicao { get; set; }
public Cor cor { get; set; }
public int qtdeMovimento { get; protected set; }
public Tabuleiro tab { get; protected set; }

public Peca (Cor cor, Tabuleiro tab){
 this.posicao = null;
 this.cor = cor;
 this.tab = tab;
 this.qtdeMovimento = 0;
}

    public Peca(Tabuleiro tab, Cor cor)
    {
        this.tab = tab;
        this.cor = cor;
    }
}
