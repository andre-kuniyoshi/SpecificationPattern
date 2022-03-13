
namespace SpecificationPattern.Domain.Interfaces
{
    internal interface ICompositeSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> And(ISpecification<T> specification);

        public ISpecification<T> Or(ISpecification<T> specification);

        public ISpecification<T> Not(ISpecification<T> specification);

    }
}
