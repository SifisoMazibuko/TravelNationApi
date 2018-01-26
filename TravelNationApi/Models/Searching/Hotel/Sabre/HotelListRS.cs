using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{

    public class HotelListRS
    {

        [JsonProperty("GetHotelListRS")]
        public GetHotelListRS GetHotelListRS { get; set; }

        [JsonProperty("Links")]
        public Link[] Links { get; set; }
    }
    public class Success
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }

    public class ApplicationResults
    {

        [JsonProperty("Success")]
        public Success[] Success { get; set; }
    }

    public class HotelInfo
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }

        [JsonProperty("HotelName")]
        public string HotelName { get; set; }

        [JsonProperty("ChainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("ChainName")]
        public string ChainName { get; set; }

        [JsonProperty("MarketerCode")]
        public string MarketerCode { get; set; }

        [JsonProperty("MarketerName")]
        public string MarketerName { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
    }
    [JsonObject(Title = "HotelRef")]
    public class HotelRef2
    {

        [JsonProperty("HotelInfo")]
        public HotelInfo[] HotelInfo { get; set; }
    }

    public class HotelList
    {

        [JsonProperty("HotelRef")]
        public HotelRef2[] HotelRef { get; set; }
    }

    public class GetHotelListRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResults ApplicationResults { get; set; }

        [JsonProperty("HotelList")]
        public HotelList HotelList { get; set; }
    }

    public class Link
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }


}
