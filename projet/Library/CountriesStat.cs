using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace projet.Library
{
    public class CountriesStat
    {
        [JsonProperty("NomPays")]
        public string NomPays { get; set; }
        [JsonProperty("NombreVue")]
        public int NombreVue { get; set; }
       [JsonProperty("Capitale")]
        public string Capitale { get; set; }
        
    }
}
