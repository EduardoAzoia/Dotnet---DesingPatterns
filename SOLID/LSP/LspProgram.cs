using static System.Console;

namespace Desing_Patterns_C_.SOLID.LSP
{
    public class LspProgram
    {
        static public int Area(Rectangle rectangle) 
            => rectangle.Width * rectangle.Height;
        public void LspMain()
        {
            Rectangle rectangle = new Rectangle(2,3);
            WriteLine($"{rectangle} has area {Area(rectangle)}");

            Rectangle square = new Square();
            square.Width = 4;
            WriteLine($"{square} has area {Area(square)}");
        }
    }
}