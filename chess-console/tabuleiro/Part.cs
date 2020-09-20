using board;
namespace board
{
   abstract class Part
    {
        public Position posicao { get; set; }
        public Color cor { get; protected set; }
        public int quantityMovements { get; protected set; }
        public Board brd { get; protected set; }

        public Part(Board brd, Color cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.brd = brd;
            this.quantityMovements = 0;
        }

        public void incrementar_quantityMovements()
        {
            quantityMovements++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < brd.linhas; i++)
            {
                for (int j = 0; j < brd.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Position pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}