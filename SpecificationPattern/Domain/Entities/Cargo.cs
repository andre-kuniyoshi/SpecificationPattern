using SpecificationPattern.Domain.Interfaces;

namespace SpecificationPattern.Domain.Entities
{
    internal class Cargo
    {
        public ISpecification<Truck> TruckSpecification;

        public Cargo(ISpecification<Truck> truckSpecification)
        {
            TruckSpecification = truckSpecification;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
