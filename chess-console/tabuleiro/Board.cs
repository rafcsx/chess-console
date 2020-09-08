using board;
namespace board
{
    class Board
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Part[,] pecas;

        public Board(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Part[linhas, colunas];
        }

        public Part peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Part peca(Position pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Position pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Part p, Position pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Part retirarPeca(Position pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Part aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Position pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Position pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}