using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Specifications.CompositeSpecification
{
    internal class OrSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> _leftSpecification;
        ISpecification<T> _rightSpecification;
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _leftSpecification = left;
            _rightSpecification = right;
        }
        public override bool IsSatisfiedBy(T o)
        {
            return _leftSpecification.IsSatisfiedBy(o)
                || _rightSpecification.IsSatisfiedBy(o);
        }
    }
}
