using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    [JsonObject(Title = "HotelRef")]
    public class HotelRefCRQ
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
    }

    [JsonObject(Title = "HotelRefs")]
    public class HotelRefsCRQ
    {

        [JsonProperty("HotelRef")]
        public HotelRefCRQ[] HotelRef { get; set; }
    }

    [JsonObject(Title = "Description")]
    public class DescriptionCRQ
    {

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    [JsonObject(Title = "Descriptions")]
    public class DescriptionsCRQ
    {

        [JsonProperty("Description")]
        public DescriptionCRQ[] Description { get; set; }
    }

    [JsonObject(Title = "DescriptiveInfoRef")]
    public class DescriptiveInfoRefCRQ
    {

        [JsonProperty("PropertyInfo")]
        public bool PropertyInfo { get; set; }

        [JsonProperty("LocationInfo")]
        public bool LocationInfo { get; set; }

        [JsonProperty("Amenities")]
        public bool Amenities { get; set; }

        [JsonProperty("Descriptions")]
        public DescriptionsCRQ Descriptions { get; set; }

        [JsonProperty("Airports")]
        public bool Airports { get; set; }

        [JsonProperty("AcceptedCreditCards")]
        public bool AcceptedCreditCards { get; set; }
    }

    [JsonObject(Title = "ImageRef")]
    public class ImageRefCRQ
    {

        [JsonProperty("MaxImages")]
        public string MaxImages { get; set; }
    }

    [JsonObject(Title = "SearchCriteria")]
    public class SearchCriteriaCRQ
    {

        [JsonProperty("HotelRefs")]
        public HotelRefsCRQ HotelRefs { get; set; }

        [JsonProperty("DescriptiveInfoRef")]
        public DescriptiveInfoRefCRQ DescriptiveInfoRef { get; set; }

        [JsonProperty("ImageRef")]
        public ImageRefCRQ ImageRef { get; set; }
    }

    public class GetHotelContentRQ
    {

        [JsonProperty("SearchCriteria")]
        public SearchCriteriaCRQ SearchCriteria { get; set; }
    }

    public class HotelContentRQ
    {

        [JsonProperty("GetHotelContentRQ")]
        public GetHotelContentRQ GetHotelContentRQ { get; set; }
    }

}
