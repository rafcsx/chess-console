using board;
namespace chess
{
    class Torre : Part
    {
        public Torre(Board brd, Color cor) : base(brd, cor) { }
        public override string ToString()
        {
            return "T";
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
            while(brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (brd.peca(pos) != null && brd.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (brd.peca(pos) != null && brd.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (brd.peca(pos) != null && brd.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna -1);
            while (brd.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (brd.peca(pos) != null && brd.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }
            return mat;
        }
    }
}