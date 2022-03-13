using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Enums;
using SpecificationPattern.Specifications.CompositeSpecification;
using SpecificationPattern.Specifications.HardCodedSpecification;
using SpecificationPattern.Specifications.ParameterizedSpecification;

namespace SpecificationPattern
{
    internal class Startup
    {
        static List<Truck> _trucks;
        static List<Cargo> _cargoes;

        internal static void CreateTrucks()
        {
            _trucks = new List<Truck>();

            var random = new Random();

            var values = Enum.GetValues<TruckTypeEnum>();

            for (var i = 0; i < 15; i++)
            {
                var truckType = (TruckTypeEnum)values.GetValue(random.Next(values.Length));

                _trucks.Add(new Truck
                {
                    Id = i,
                    Type = truckType,
                    MaxWeightCapacity = random.Next(10, 60),
                    InternalTemperature = GenerateTruckTemperatures(truckType, random)
                }); ;
            }
        }

        internal static int GenerateTruckTemperatures(TruckTypeEnum truckType, Random random)
        {
            if (truckType == TruckTypeEnum.Refrigerated)
                return random.Next(-15, -5);
            else
                return 25;
        }

        internal static void CreateCargos()
        {
            _cargoes = new List<Cargo>();

            // Exemple of use Hardcoded Specification
            _cargoes.Add(new Cargo(new FishStorageSpecification())
            {
                Id = 1,
                Name = "Fishes",
                Weight = 20
            });

            // Exemple of use Hardcoded Specification
            _cargoes.Add(new Cargo(new FurnitureStorageSpecification())
            {
                Id = 2,
                Name = "Beds",
                Weight = 35
            });

            // Exemple of use Parameterized Specification
            _cargoes.Add(new Cargo(new PerishableStorageSpecification(-7, 0))
            {
                Id = 3,
                Name = "Tomatoes",
                Weight = 15
            });

            // Exemple of use Composite Specification
            _cargoes.Add(new Cargo(new AndSpecification<Truck>(new ValuableStorageSpecification(), new HeavyLoadStorageSpecification(50)))
            {
                Id = 4,
                Name = "Gold bars",
                Weight = 50
            });
        }

        internal static void CheckSpecs()
        {
            foreach (var cargo in _cargoes)
            {
                Console.WriteLine($"Cargo Id: {cargo.Id} , Name: {cargo.Name}, Weight: {cargo.Weight}");
                Console.WriteLine();
                foreach (var truck in _trucks)
                {
                    Console.WriteLine("Truck infos:");
                    Console.WriteLine($"Id = {truck.Id}, type = {truck.Type}, Internal Temperature = {truck.InternalTemperature}, MaxWeight = {truck.MaxWeightCapacity}");
                    Console.Write("Is truck ok? --> ");
                    Console.WriteLine(cargo.TruckSpecification.IsSatisfiedBy(truck) ? "OK!" : "NOT OK!");
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            }
        }
    }
}
