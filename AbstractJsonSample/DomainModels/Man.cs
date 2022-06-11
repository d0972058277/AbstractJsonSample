using AbstractJsonSample.DomainModels.Vehicles;

namespace AbstractJsonSample.DomainModels
{
    public class Man
    {
        private Man()
        {
            Id = Guid.NewGuid();
            _vehicles = new List<Vehicle>();
        }

        public Man(Guid id, List<Vehicle> vehicles)
        {
            Id = id;
            _vehicles = vehicles;
        }

        public Guid Id { get; }

        private List<Vehicle> _vehicles;
        public IReadOnlyList<Vehicle> Vehicles => _vehicles.ToList();

        public static Man Create() => new Man();

        public void Buy(Vehicle vehicle) => _vehicles.Add(vehicle);
    }
}