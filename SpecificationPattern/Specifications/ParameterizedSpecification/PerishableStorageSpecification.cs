using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Enums;

namespace SpecificationPattern.Specifications.ParameterizedSpecification
{
    internal class PerishableStorageSpecification : Specification<Truck>
    {
        private readonly int _maxTemperature;
        private readonly int _minTemperature;
        public PerishableStorageSpecification(int minTemperature, int maxTemperature)
        {
            _maxTemperature = maxTemperature;
            _minTemperature = minTemperature;
        }
        public override bool IsSatisfiedBy(Truck truck)
        { 
            return truck.Type == TruckTypeEnum.Refrigerated && truck.InternalTemperature >= _minTemperature && truck.InternalTemperature <= _maxTemperature;
        }
    
    }
}
