using AbstractJsonSample.DomainModels.Engines;

namespace AbstractJsonSample.DomainModels.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(Engine engine)
        {
            Engine = engine;
        }

        public Engine Engine { get; }
    }
}