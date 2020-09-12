using System;
using board;
using chess;
namespace chess_console
{
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
                    Tela.imprimirBoard(partida.brd);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicaoPossiveis = partida.brd.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirBoard(partida.brd, posicaoPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Position destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                Tela.imprimirBoard(partida.brd);
            }
            catch (TabuleiroException boardEX)
            {
                Console.WriteLine(boardEX.Message);
            }
            Console.ReadLine();
        }
    }
}