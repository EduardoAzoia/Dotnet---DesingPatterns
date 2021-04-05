namespace Desing_Patterns_C_.SOLID.LSP
{
    public class Square : Rectangle
    {
        public override int Width
        {
            set {base.Width = base.Height = value; }
        }

        public override int Height
        {
            set {base.Width = base.Height = value; }
        }
    }
}