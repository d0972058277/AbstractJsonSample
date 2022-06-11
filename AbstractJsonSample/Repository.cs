using AbstractJsonSample.DomainModels;
using Newtonsoft.Json;

namespace AbstractJsonSample
{
    public class Repository
    {
        private Dictionary<Guid, string> _cache;

        public Repository()
        {
            _cache = new Dictionary<Guid, string>();
        }

        public Man Find(Guid id)
        {
            var json = _cache[id];
            return JsonConvert.DeserializeObject<Man>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }) !;
        }

        public void Save(Man man)
        {
            var json = JsonConvert.SerializeObject(man, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            Console.WriteLine(json);
            _cache.Add(man.Id, json);
        }
    }
}