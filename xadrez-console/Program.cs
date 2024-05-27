namespace Chess;
using tabuleiro;
using xadrez;

class Program
{
    static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('c', 7);
        System.Console.WriteLine(pos);

        System.Console.WriteLine(pos.toPosicao());
        Console.ReadLine();

    }

}
