using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Enums;

namespace SpecificationPattern.Specifications.HardCodedSpecification
{
    internal class FishStorageSpecification : Specification<Truck>
    {
        public override bool IsSatisfiedBy(Truck truck)
        {
            return truck.Type == TruckTypeEnum.Refrigerated && truck.InternalTemperature <= -10;
        }
    }
}
