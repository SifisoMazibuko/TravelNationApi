using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelImageRQ
    {

        [JsonProperty("GetHotelImageRQ")]
        public GetHotelImageRQ GetHotelImageRQ { get; set; }
    }
    [JsonObject(Title = "HotelRef")]
    public class HotelRef1
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }

        [JsonProperty("CodeContext")]
        public string CodeContext { get; set; }
    }
    [JsonObject(Title = "HotelRefs")]
    public class HotelRefs2
    {

        [JsonProperty("HotelRef")]
        public HotelRef1[] HotelRef { get; set; }
    }

    public class ImageRef
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("CategoryCode")]
        public int CategoryCode { get; set; }

        [JsonProperty("LanguageCode")]
        public string LanguageCode { get; set; }
    }

    public class GetHotelImageRQ
    {

        [JsonProperty("HotelRefs")]
        public HotelRefs HotelRefs { get; set; }

        [JsonProperty("ImageRef")]
        public ImageRef ImageRef { get; set; }
    }
}
