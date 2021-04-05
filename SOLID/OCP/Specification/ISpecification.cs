namespace Desing_Patterns_C_.SOLID.OCP.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}