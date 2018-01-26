using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    [JsonObject(Title = "Success")]
    public class SuccessMRS
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }
    [JsonObject(Title = "ApplicationResults")]
    public class ApplicationResultsMRS
    {

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("Success")]
        public SuccessMRS[] Success { get; set; }
    }

    [JsonObject(Title = "HotelInfo")]
    public class HotelInfoMRS
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }

        [JsonProperty("CodeContext")]
        public string CodeContext { get; set; }

        [JsonProperty("ChainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("Marketer")]
        public string Marketer { get; set; }

        [JsonProperty("Logo")]
        public string Logo { get; set; }
    }

    public class Image
    {

        [JsonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Height")]
        public int Height { get; set; }

        [JsonProperty("Width")]
        public int Width { get; set; }
    }

    public class Images
    {

        [JsonProperty("Image")]
        public Image[] Image { get; set; }
    }

    public class Text
    {

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Description
    {

        [JsonProperty("Text")]
        public Text[] Text { get; set; }
    }

    public class Category
    {

        [JsonProperty("CategoryCode")]
        public int CategoryCode { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }
    }

    public class Text2
    {

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Description2
    {

        [JsonProperty("Text")]
        public Text2[] Text { get; set; }
    }

    public class Info
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Description")]
        public Description2 Description { get; set; }
    }

    public class AdditionalInfo
    {

        [JsonProperty("Info")]
        public Info[] Info { get; set; }
    }

    public class ImageItem
    {

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("Format")]
        public string Format { get; set; }

        [JsonProperty("LastModifedDate")]
        public string LastModifedDate { get; set; }

        [JsonProperty("Images")]
        public Images Images { get; set; }

        [JsonProperty("Category")]
        public Category Category { get; set; }

        [JsonProperty("AdditionalInfo")]
        public AdditionalInfo AdditionalInfo { get; set; }
    }

    public class ImageItems
    {

        [JsonProperty("ImageItem")]
        public ImageItem[] ImageItem { get; set; }
    }

    public class HotelMediaInfo
    {

        [JsonProperty("HotelInfo")]
        public HotelInfoMRS HotelInfo { get; set; }

        [JsonProperty("ImageItems")]
        public ImageItems ImageItems { get; set; }
    }

    public class HotelMediaInfos
    {

        [JsonProperty("HotelMediaInfo")]
        public HotelMediaInfo[] HotelMediaInfo { get; set; }
    }

    public class GetHotelMediaRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResultsMRS ApplicationResults { get; set; }

        [JsonProperty("HotelMediaInfos")]
        public HotelMediaInfos HotelMediaInfos { get; set; }
    }
    
    public class HotelMediaRS
    {

        [JsonProperty("GetHotelMediaRS")]
        public GetHotelMediaRS GetHotelMediaRS { get; set; }

        [JsonProperty("Links")]
        public Link[] Links { get; set; }
    }

}
