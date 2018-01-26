using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class GetHotelChainInfoRQ
    {
    }

    public class HotelChainRQ
    {

        [JsonProperty("GetHotelChainInfoRQ")]
        public GetHotelChainInfoRQ GetHotelChainInfoRQ { get; set; }
    }

}
