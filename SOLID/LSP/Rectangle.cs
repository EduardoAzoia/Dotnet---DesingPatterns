namespace Desing_Patterns_C_.SOLID.LSP
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle ()
        {

        }
        public Rectangle(int width, int heigth)
        {
            Width = width;
            Height = heigth;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}