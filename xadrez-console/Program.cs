namespace Chess;
using System;
using tabuleiro;
using xadrez;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada)
            {

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

               bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPosiveis);

                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
            }

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();

    }

}
