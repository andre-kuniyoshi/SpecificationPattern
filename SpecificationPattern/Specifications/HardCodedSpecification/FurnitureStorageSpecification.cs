using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Enums;

namespace SpecificationPattern.Specifications.HardCodedSpecification
{
    internal class FurnitureStorageSpecification : Specification<Truck>
    {
        public override bool IsSatisfiedBy(Truck truck)
        {
            return truck.Type == TruckTypeEnum.Normal && truck.InternalTemperature > 0 && truck.MaxWeightCapacity > 20;
        }
    }
}
