using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Car.Sabre
{
    public class CarRQ
    {

        [JsonProperty("OTA_VehAvailRateRQ")]
        public OTAVehAvailRateRQ OTAVehAvailRateRQ { get; set; }
    }

    public class PickUpLocation
    {

        [JsonProperty("LocationCode")]
        public string LocationCode { get; set; }
    }

    [JsonObject(Title = "VehRentalCore")]
    public class VehRentalCore2
    {

        [JsonProperty("PickUpDateTime")]
        public string PickUpDateTime { get; set; }

        [JsonProperty("ReturnDateTime")]
        public string ReturnDateTime { get; set; }

        [JsonProperty("PickUpLocation")]
        public PickUpLocation PickUpLocation { get; set; }
    }

    public class VehAvailRQCore
    {

        [JsonProperty("QueryType")]
        public string QueryType { get; set; }

        [JsonProperty("VehRentalCore")]
        public VehRentalCore2 VehRentalCore { get; set; }
    }

    public class OTAVehAvailRateRQ
    {

        [JsonProperty("VehAvailRQCore")]
        public VehAvailRQCore VehAvailRQCore { get; set; }
    }
}
