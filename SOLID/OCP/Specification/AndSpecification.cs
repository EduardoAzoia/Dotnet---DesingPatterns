using System;

namespace Desing_Patterns_C_.SOLID.OCP.Specification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first, _second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }
}