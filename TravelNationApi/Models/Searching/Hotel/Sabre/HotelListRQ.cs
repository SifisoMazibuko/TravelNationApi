using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelListRQ
    {
        [JsonProperty("GetHotelListRQ")]
        public GetHotelListRQ GetHotelListRQ { get; set; }
    }
    public class HotelRef
    {
        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
    }

    public class HotelRefs
    {
        [JsonProperty("HotelRef")]
        public HotelRef[] HotelRef { get; set; }
    }

    public class SearchCriteria
    {
        [JsonProperty("IncludedFeatures")]
        public bool IncludedFeatures { get; set; }

        [JsonProperty("HotelRefs")]
        public HotelRefs HotelRefs { get; set; }
    }

    public class GetHotelListRQ
    {
        [JsonProperty("SearchCriteria")]
        public SearchCriteria SearchCriteria { get; set; }
    }
}
