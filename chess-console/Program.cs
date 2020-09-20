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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirBoard(partida.brd);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Position origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicaoPossiveis = partida.brd.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirBoard(partida.brd, posicaoPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Position destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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