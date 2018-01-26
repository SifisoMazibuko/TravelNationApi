using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    [JsonObject(Title = "Image")]
    public class ImageMRQ
    {

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    [JsonObject(Title = "Images")]
    public class ImagesMRQ
    {

        [JsonProperty("Image")]
        public ImageMRQ[] Image { get; set; }
    }

    [JsonObject(Title = "Category")]
    public class CategoryMRQ
    {

        [JsonProperty("Code")]
        public int Code { get; set; }
    }

    public class Categories
    {

        [JsonProperty("Category")]
        public CategoryMRQ[] Category { get; set; }
    }

    [JsonObject(Title = "Info")]
    public class InfoMRQ
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public bool Content { get; set; }
    }

    [JsonObject(Title = "AdditionalInfo")]
    public class AdditionalInfoMRQ
    {

        [JsonProperty("Info")]
        public InfoMRQ[] Info { get; set; }
    }

    public class Language
    {

        [JsonProperty("Code")]
        public string Code { get; set; }
    }

    public class Languages
    {

        [JsonProperty("Language")]
        public Language[] Language { get; set; }
    }
    [JsonObject(Title = "ImageRef")]
    public class ImageRefMRQ
    {

        [JsonProperty("MaxImages")]
        public string MaxImages { get; set; }

        [JsonProperty("Images")]
        public ImagesMRQ Images { get; set; }

        [JsonProperty("Categories")]
        public Categories Categories { get; set; }

        [JsonProperty("AdditionalInfo")]
        public AdditionalInfoMRQ AdditionalInfo { get; set; }

        [JsonProperty("Languages")]
        public Languages Languages { get; set; }
    }

    [JsonObject(Title = "HotelRef")]
    public class HotelRefMRQ
    {

        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }

        [JsonProperty("CodeContext")]
        public string CodeContext { get; set; }

        [JsonProperty("ImageRef")]
        public ImageRefMRQ ImageRef { get; set; }
    }

    [JsonObject(Title = "HotelRefs")]
    public class HotelRefsMRQ
    {

        [JsonProperty("HotelRef")]
        public HotelRefMRQ[] HotelRef { get; set; }
    }

    public class GetHotelMediaRQ
    {

        [JsonProperty("HotelRefs")]
        public HotelRefsMRQ HotelRefs { get; set; }
    }

    public class HotelMediaRQ
    {

        [JsonProperty("GetHotelMediaRQ")]
        public GetHotelMediaRQ GetHotelMediaRQ { get; set; }
    }
}
