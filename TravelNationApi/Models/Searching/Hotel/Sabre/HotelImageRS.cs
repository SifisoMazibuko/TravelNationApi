using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelImageRS
    {

        [JsonProperty("GetHotelImageRS")]
        public GetHotelImageRS GetHotelImageRS { get; set; }

        [JsonProperty("Links")]
        public Link1[] Links { get; set; }
    }
    [JsonObject(Title = "Success")]
    public class Success1
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }
    [JsonObject(Title = "ApplicationResults")]
    public class ApplicationResults1
    {

        [JsonProperty("Success")]
        public Success1[] Success { get; set; }
    }

    public class HotelImageInfos
    {
    }

    public class GetHotelImageRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResults1 ApplicationResults { get; set; }

        [JsonProperty("HotelImageInfos")]
        public HotelImageInfos HotelImageInfos { get; set; }
    }
    [JsonObject(Title = "Link")]
    public class Link1
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }  

}
