using SpecificationPattern.Domain.Enums;

namespace SpecificationPattern.Domain.Entities
{
    internal class Truck
    {
        public int Id { get; set; }
        public TruckTypeEnum Type { get; set; }
        public int InternalTemperature { get; set; }
        public int MaxWeightCapacity { get; set; }
    }
}
