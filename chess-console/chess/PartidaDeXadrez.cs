using System;
using board;

namespace chess
{
    class PartidaDeXadrez
    {
        public Board brd { get; private set; }
        public int turno;
        public Color jogadorAtual;
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

        public void realizaJogada(Position origem, Position destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Position pos)
        {
            if (brd.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != brd.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!brd.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem!");
            }
        }

        public void validarPosicaoDeDestino(Position origem, Position destino)
        {
            if (!brd.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Color.Branca)
            {
                jogadorAtual = Color.Preta;
            }
            else
            {
                jogadorAtual = Color.Branca;
            }
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
