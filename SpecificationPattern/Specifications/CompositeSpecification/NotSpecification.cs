using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Specifications.CompositeSpecification
{
    internal class NotSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> spec)
        {
            _specification = spec;
        }
        public override bool IsSatisfiedBy(T o)
        {
            return !_specification.IsSatisfiedBy(o);
        }
    }
}
