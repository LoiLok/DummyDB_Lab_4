using Newtonsoft.Json;
namespace DummyDB_4
{
    public class Scheme
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("columns")]
        public List<SchemeColumn> Columns { get; set; }

        public static Scheme ReadJsonFile(string path)
        {
            return JsonConvert.DeserializeObject<Scheme>(File.ReadAllText(path));
        }
    }
}
