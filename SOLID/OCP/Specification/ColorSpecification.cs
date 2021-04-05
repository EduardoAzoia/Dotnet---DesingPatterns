namespace Desing_Patterns_C_.SOLID.OCP.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            this._color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}