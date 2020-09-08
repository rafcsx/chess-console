using System;
using board;
using chess;
namespace chess_console
{
    class Tela
    {
        public static void imprimirBoard(Board brd)
        {
            for (int i = 0; i < brd.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.colunas; j++)
                {
                    
                    if (brd.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(brd.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Part peca)
        {
            if (peca.cor == Color.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}