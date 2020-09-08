using board;
namespace chess
{
    class Rei : Part
    {
        public Rei(Board brd, Color cor) : base(brd, cor) { }
        public override string ToString()
        {
            return "R ";
        }
    }
}