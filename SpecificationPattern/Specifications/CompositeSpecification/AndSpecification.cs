using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Specifications.CompositeSpecification
{
    internal class AndSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> _leftSpecification;
        ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _leftSpecification = left;
            _rightSpecification = right;
        }

        public override bool IsSatisfiedBy(T obj)
        {
            return _leftSpecification.IsSatisfiedBy(obj)
                && _rightSpecification.IsSatisfiedBy(obj);
        }
    }
}
