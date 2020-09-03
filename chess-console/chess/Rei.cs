using chess_console.tabuleiro;

namespace chess_console.chess
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString()
        {
            return "R";
        }
    }

}
