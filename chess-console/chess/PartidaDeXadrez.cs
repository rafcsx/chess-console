using System;
using board;

namespace chess
{
    class PartidaDeXadrez
    {
        public Board brd { get; private set; }
        private int turno;
        private Color jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            brd = new Board(8, 8);
            turno = 1;
            jogadorAtual = Color.Branca;
            colocarPecas();
            terminada = false;
        }

        public void executaMovimento(Position origem, Position destino)
        {
            Part p = brd.retirarPeca(origem);
            p.incrementar_quantityMovements();
            Part pecaCapturada = brd.retirarPeca(destino);
            brd.colocarPeca(p, destino);
        }
    

        private void colocarPecas()
        {
            brd.colocarPeca(new Torre(brd, Color.Branca), new PosicaoXadrez('c', 1).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Branca), new PosicaoXadrez('c', 2).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Branca), new PosicaoXadrez('d', 2).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Branca), new PosicaoXadrez('e', 2).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Branca), new PosicaoXadrez('e', 1).toPosicao());
            brd.colocarPeca(new Rei(brd, Color.Branca), new PosicaoXadrez('d', 1).toPosicao());

            brd.colocarPeca(new Torre(brd, Color.Preta), new PosicaoXadrez('c', 7).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Preta), new PosicaoXadrez('c', 8).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Preta), new PosicaoXadrez('d', 7).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Preta), new PosicaoXadrez('e', 7).toPosicao());
            brd.colocarPeca(new Torre(brd, Color.Preta), new PosicaoXadrez('e', 8).toPosicao());
            brd.colocarPeca(new Rei(brd, Color.Preta), new PosicaoXadrez('d', 8).toPosicao());
        }
    }
}
