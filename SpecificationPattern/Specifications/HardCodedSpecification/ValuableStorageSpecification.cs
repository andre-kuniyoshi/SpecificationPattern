using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Enums;

namespace SpecificationPattern.Specifications.HardCodedSpecification
{
    internal class ValuableStorageSpecification : Specification<Truck>
    {
        public override bool IsSatisfiedBy(Truck truck)
        {
            return truck.Type == TruckTypeEnum.Armored;
        }
    }
}
