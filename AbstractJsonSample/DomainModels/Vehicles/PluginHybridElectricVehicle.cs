using AbstractJsonSample.DomainModels.Engines;

namespace AbstractJsonSample.DomainModels.Vehicles
{
    public class PluginHybridElectricVehicle : Vehicle
    {
        public PluginHybridElectricVehicle(Engine engine) : base(engine) { }
    }
}