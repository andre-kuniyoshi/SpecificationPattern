using SpecificationPattern.Domain.Entities;

namespace SpecificationPattern.Specifications.ParameterizedSpecification
{
    internal class HeavyLoadStorageSpecification : Specification<Truck>
    {
        private readonly int _maxWeight;
        public HeavyLoadStorageSpecification(int maxWeight)
        {
            _maxWeight = maxWeight;
        }
        public override bool IsSatisfiedBy(Truck truck)
        {
            return truck.MaxWeightCapacity >= _maxWeight;
        }
    }
}
