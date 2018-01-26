using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelContentChangeRS
    {
        [JsonProperty("GetHotelContentChangeRS")]
        public GetHotelContentChangeRS GetHotelContentChangeRS { get; set; }

        [JsonProperty("Links")]
        public LinkCCRS[] Links { get; set; }
    }

    [JsonObject(Title = "Success")]
    public class SuccessCCRS
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }

    public class ApplicationResultsCCRS
    {

        [JsonProperty("Success")]
        public SuccessCCRS[] Success { get; set; }
    }

    public class HotelContentChanges
    {
    }

    [JsonObject(Title = "ApplicationResults")]
    public class GetHotelContentChangeRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResultsCCRS ApplicationResults { get; set; }

        [JsonProperty("HotelContentChanges")]
        public HotelContentChanges HotelContentChanges { get; set; }
    }

    [JsonObject(Title = "Link")]
    public class LinkCCRS
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
