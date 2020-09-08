using board;
namespace chess
{
    class Torre : Part
    {
        public Torre(Board brd, Color cor) : base(brd, cor) { }
        public override string ToString()
        {
            return "T ";
        }
    }
}
