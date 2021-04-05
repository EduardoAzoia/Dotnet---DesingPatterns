using System.Collections.Generic;
using Desing_Patterns_C_.SOLID.OCP.Specification;

namespace Desing_Patterns_C_.SOLID.OCP.Filter
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}