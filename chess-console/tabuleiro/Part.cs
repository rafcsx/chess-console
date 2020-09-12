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

        public abstract bool[,] movimentosPossiveis();
    }
}