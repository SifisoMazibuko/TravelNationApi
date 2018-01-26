using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{

    public class HotelContentChangeRQ
    {

        [JsonProperty("GetHotelContentChangeRQ")]
        public GetHotelContentChangeRQ GetHotelContentChangeRQ { get; set; }
    }
    public class ContentChangeRef
    {

        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("EndDate")]
        public string EndDate { get; set; }
    }

    public class GetHotelContentChangeRQ
    {

        [JsonProperty("ContentChangeRef")]
        public ContentChangeRef ContentChangeRef { get; set; }
    }
 }
