using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Specifications.CompositeSpecification
{
    internal abstract class CompositeSpecification<T> : ICompositeSpecification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }
    }
}
