using AbstractJsonSample.DomainModels.Engines;

namespace AbstractJsonSample.DomainModels.Vehicles
{
    public class BatteryElectricVehicle : Vehicle
    {
        public BatteryElectricVehicle(Engine engine) : base(engine) { }
    }
}