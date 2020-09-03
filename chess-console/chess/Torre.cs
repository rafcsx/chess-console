using chess_console.tabuleiro;
namespace chess_console.chess
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString()
        {
            return "T";
        }
    }
}
