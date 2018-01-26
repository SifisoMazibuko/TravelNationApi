using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelChainRS
    {

        [JsonProperty("GetHotelChainInfoRS")]
        public GetHotelChainInfoRS GetHotelChainInfoRS { get; set; }

        [JsonProperty("Links")]
        public Link1[] Links { get; set; }
    }
    [JsonObject(Title = "Success")]
    public class Success_
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }
    [JsonObject(Title = "ApplicationResults")]
    public class Application_Results
    {

        [JsonProperty("Success")]
        public Success1[] Success { get; set; }
    }

    public class Chain
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public class Chains
    {

        [JsonProperty("Chain")]
        public Chain[] Chain { get; set; }
    }

    public class Marketer
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Chains")]
        public Chains Chains { get; set; }
    }

    public class Marketers
    {

        [JsonProperty("Marketer")]
        public Marketer[] Marketer { get; set; }
    }

    public class GetHotelChainInfoRS
    {

        [JsonProperty("ApplicationResults")]
        public Application_Results ApplicationResults { get; set; }

        [JsonProperty("Marketers")]
        public Marketers Marketers { get; set; }
    }
    [JsonObject(Title = "Link")]
    public class Link_
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

}
