using AbstractJsonSample.DomainModels.Engines;

namespace AbstractJsonSample.DomainModels.Vehicles
{
    public class ExtendedRangeElectricVehicle : Vehicle
    {
        public ExtendedRangeElectricVehicle(Engine engine) : base(engine) { }
    }
}