
namespace SpecificationPattern.Domain.Interfaces
{
    internal interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
