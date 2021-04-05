using System.Collections.Generic;
using Desing_Patterns_C_.SOLID.OCP.Specification;

namespace Desing_Patterns_C_.SOLID.OCP.Filter
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}