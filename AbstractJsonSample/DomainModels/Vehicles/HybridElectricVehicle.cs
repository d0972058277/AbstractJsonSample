using AbstractJsonSample.DomainModels.Engines;

namespace AbstractJsonSample.DomainModels.Vehicles
{
    public class HybridElectricVehicle : Vehicle
    {
        public HybridElectricVehicle(Engine engine) : base(engine) { }
    }
}