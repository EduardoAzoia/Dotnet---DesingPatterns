using Desing_Patterns_C_.SOLID.OCP.Filter;
using Desing_Patterns_C_.SOLID.OCP.Specification;
using static System.Console;

namespace Desing_Patterns_C_.SOLID.OCP
{
    public class OcpProgram
    {
        public void OcpMain()
        {

            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = {apple, tree, house};

            var betterFilter = new BetterFilter();
            WriteLine("Green products (new):");
            var greenProducts = betterFilter.Filter(products, new ColorSpecification(Color.Green));
            foreach (var product in greenProducts)
            {
                WriteLine($" - {product.Name} is green");
            }

            var largeAndBlueSpecification = new AndSpecification<Product>
            (
                new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)
            );

            var largeBlueProducts = betterFilter.Filter(products, largeAndBlueSpecification);
            WriteLine("Large blue items");
            foreach (var product in largeBlueProducts)
            {
                WriteLine($" - {product.Name} is large and blue");
            }
        }
    }
}