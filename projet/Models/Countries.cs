using Newtonsoft.Json;

namespace projet.Models
{
    public class Countries
    {
        [JsonProperty(PropertyName = "common")]
        public string Name { get; set; }


    }
}
