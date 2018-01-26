using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class GetHotelDescriptiveInfoRQ
    {

        [JsonProperty("HotelRefs")]
        public HotelRefsDIRQ HotelRefs { get; set; }

        [JsonProperty("DescriptiveInfoRef")]
        public DescriptiveInfoRef DescriptiveInfoRef { get; set; }
    }
    public class HotelDescriptiveInfoRQ
    {

        [JsonProperty("GetHotelDescriptiveInfoRQ")]
        public GetHotelDescriptiveInfoRQ GetHotelDescriptiveInfoRQ { get; set; }
    }

    [JsonObject(Title = "HotelRef")]
    public class HotelRefDIRQ
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
    }

    [JsonObject(Title = "HotelRefs")]
    public class HotelRefsDIRQ
    {

        [JsonProperty("HotelRef")]
        public HotelRefDIRQ[] HotelRef { get; set; }
    }

    [JsonObject(Title = "Description")]
    public class DescriptionDIRQ
    {

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    public class Descriptions
    {

        [JsonProperty("Description")]
        public DescriptionDIRQ[] Description { get; set; }
    }

    public class DescriptiveInfoRef
    {

        [JsonProperty("PropertyInfo")]
        public bool PropertyInfo { get; set; }

        [JsonProperty("LocationInfo")]
        public bool LocationInfo { get; set; }

        [JsonProperty("Amenities")]
        public bool Amenities { get; set; }

        [JsonProperty("Descriptions")]
        public Descriptions Descriptions { get; set; }

        [JsonProperty("Airports")]
        public bool Airports { get; set; }

        [JsonProperty("AcceptedCreditCards")]
        public bool AcceptedCreditCards { get; set; }
    }

}
