namespace AbstractJsonSample.DomainModels.Engines
{
    public abstract class Engine
    {
        protected Engine(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}