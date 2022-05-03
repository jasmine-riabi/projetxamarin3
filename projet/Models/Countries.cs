using Newtonsoft.Json;
using System;

namespace projet.Models
{
    public class Countries
    {
        [JsonProperty(PropertyName = "common")]
        public string Name { get; set; }
        public bool Like { get; set; }
        public int NombreVue { get; set; }
        [JsonProperty("flag")]
        public string Flag { get; set; }
        /*         [JsonProperty("flags")]
               public CoatOfArms Flags { get; set; }

                [JsonProperty("coatOfArms")]
                public CoatOfArms CoatOfArms { get; set; }*/

        [JsonProperty("capital")]
        public string[] Capital { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        /*[JsonProperty("currencies")]*/
        /*        public Currencies Currencies { get; set; }*/

        /* public partial class CoatOfArms
         {
             [JsonProperty("png")]
             public Uri Png { get; set; }

             [JsonProperty("svg")]
             public Uri Svg { get; set; }
         }

         public partial class Currencies
         {
             [JsonProperty("BYN")]
             public Byn Byn { get; set; }
         }*/

        public partial class Byn
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("symbol")]
            public string Symbol { get; set; }
        }

/*        public partial class Name
        {
            [JsonProperty("common")]
            public string Common { get; set; }

            [JsonProperty("official")]
            public string Official { get; set; }

            [JsonProperty("nativeName")]
            public NativeName NativeName { get; set; }
        }*/

    }
}
