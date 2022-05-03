namespace projet.Service
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Country
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        public bool Like { get; set; }

        public int NombreVue { get; set; }

        [JsonProperty("tld")]
        public string[] Tld { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("ccn3")]
        public long Ccn3 { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }

        [JsonProperty("independent")]
        public bool Independent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unMember")]
        public bool UnMember { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("idd")]
        public Idd Idd { get; set; }

        [JsonProperty("capital")]
        public string[] Capital { get; set; }

        [JsonProperty("altSpellings")]
        public string[] AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public Languages Languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        [JsonProperty("latlng")]
        public long[] Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("area")]
        public long Area { get; set; }

        [JsonProperty("demonyms")]
        public Demonyms Demonyms { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public Maps Maps { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("gini")]
        public Gini Gini { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("car")]
        public Car Car { get; set; }

        [JsonProperty("timezones")]
        public string[] Timezones { get; set; }

        [JsonProperty("continents")]
        public string[] Continents { get; set; }

        [JsonProperty("flags")]
        public CoatOfArms Flags { get; set; }

        [JsonProperty("coatOfArms")]
        public CoatOfArms CoatOfArms { get; set; }

        [JsonProperty("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonProperty("postalCode")]
        public PostalCode PostalCode { get; set; }
    }

    public partial class CapitalInfo
    {
        [JsonProperty("latlng")]
        public double[] Latlng { get; set; }
    }

    public partial class Car
    {
        [JsonProperty("signs")]
        public string[] Signs { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }

    public partial class CoatOfArms
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
    }

    public partial class Byn
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public partial class Demonyms
    {
        [JsonProperty("eng")]
        public Eng Eng { get; set; }

        [JsonProperty("fra")]
        public Eng Fra { get; set; }
    }

    public partial class Eng
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public partial class Gini
    {
        [JsonProperty("2019")]
        public double The2019 { get; set; }
    }

    public partial class Idd
    {
        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("suffixes")]
        public long[] Suffixes { get; set; }
    }

    public partial class Languages
    {
        [JsonProperty("bel")]
        public string Bel { get; set; }

        [JsonProperty("rus")]
        public string Rus { get; set; }
    }

    public partial class Maps
    {
        [JsonProperty("googleMaps")]
        public Uri GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public Uri OpenStreetMaps { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public NativeName NativeName { get; set; }
    }

    public partial class NativeName
    {
        [JsonProperty("bel")]
        public Translation Bel { get; set; }

        [JsonProperty("rus")]
        public Translation Rus { get; set; }
    }

    public partial class Translation
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public partial class PostalCode
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("regex")]
        public string Regex { get; set; }
    }
}