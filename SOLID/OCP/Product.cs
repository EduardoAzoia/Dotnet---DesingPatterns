using System;

namespace Desing_Patterns_C_.SOLID.OCP
{
    public class Product
    {
        public string Name;
        public Color Color;
        public  Size Size;
        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                if (name == null)
                {
                    throw new ArgumentNullException(paramName: nameof(name));
                }
            }

            Size = size;
            Color = color;
            Name = name;
        }
    }
}