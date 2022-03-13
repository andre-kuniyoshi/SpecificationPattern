using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Specifications
{
    internal abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);
    }
}
