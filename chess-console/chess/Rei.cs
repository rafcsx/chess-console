using board;
namespace chess
{
    class Rei : Part
    {
        public Rei(Board brd, Color cor) : base(brd, cor) { }
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Position pos)
        {
            Part p = brd.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[brd.linhas, brd.colunas];

            Position pos = new Position(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // so
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // no
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}