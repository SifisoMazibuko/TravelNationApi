using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    public class HotelDescriptiveInfoRS
    {

        [JsonProperty("GetHotelDescriptiveInfoRS")]
        public GetHotelDescriptiveInfoRS GetHotelDescriptiveInfoRS { get; set; }

        [JsonProperty("Links")]
        public Link_1[] Links { get; set; }
    }
    [JsonObject(Title = "Success")]
    public class SuccessDIRS
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }
    [JsonObject(Title = "ApplicationResults")]
    public class ApplicationResultsDIRS
    {

        [JsonProperty("Success")]
        public SuccessDIRS[] Success { get; set; }
    }

    [JsonObject(Title = "HotelInfo")]
    public class HotelInfoDIRS
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

    public class PropertyTypeInfo
    {
    }

    public class PropertyFeatures
    {
    }

    [JsonObject(Title = "Text")]
    public class TextDIRS
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Policy
    {

        [JsonProperty("Text")]
        public TextDIRS Text { get; set; }
    }

    public class Policies
    {

        [JsonProperty("Policy")]
        public Policy[] Policy { get; set; }
    }

    public class PropertyQuality
    {

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class PropertyQualityInfo
    {

        [JsonProperty("PropertyQuality")]
        public PropertyQuality[] PropertyQuality { get; set; }
    }

    public class PropertyTax
    {

        [JsonProperty("Info")]
        public string Info { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class PropertyTaxes
    {

        [JsonProperty("PropertyTax")]
        public PropertyTax[] PropertyTax { get; set; }
    }

    public class RoomTraits
    {
    }

    public class RequestableAmenities
    {
    }

    public class PropertyInfo
    {

        [JsonProperty("Floors")]
        public string Floors { get; set; }

        [JsonProperty("Rooms")]
        public string Rooms { get; set; }

        [JsonProperty("PropertyTypeInfo")]
        public PropertyTypeInfo PropertyTypeInfo { get; set; }

        [JsonProperty("PropertyFeatures")]
        public PropertyFeatures PropertyFeatures { get; set; }

        [JsonProperty("Policies")]
        public Policies Policies { get; set; }

        [JsonProperty("PropertyQualityInfo")]
        public PropertyQualityInfo PropertyQualityInfo { get; set; }

        [JsonProperty("PropertyTaxes")]
        public PropertyTaxes PropertyTaxes { get; set; }

        [JsonProperty("RoomTraits")]
        public RoomTraits RoomTraits { get; set; }

        [JsonProperty("RequestableAmenities")]
        public RequestableAmenities RequestableAmenities { get; set; }
    }

    public class StateProv
    {

        [JsonProperty("StateCode")]
        public string StateCode { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class CountryName
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Address
    {

        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("CityName")]
        public string CityName { get; set; }

        [JsonProperty("StateProv")]
        public StateProv StateProv { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("CountryName")]
        public CountryName CountryName { get; set; }
    }

    public class Contact
    {

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }
    }

    public class LocationInfo
    {

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("Contact")]
        public Contact Contact { get; set; }
    }

    public class Amenity
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AdditionalCharge")]
        public bool? AdditionalCharge { get; set; }
    }

    public class Amenities
    {

        [JsonProperty("Amenity")]
        public Amenity[] Amenity { get; set; }
    }

    [JsonObject(Title = "Text2")]
    public class Text2DIRS
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "Description")]
    public class DescriptionDIRS
    {

        [JsonProperty("Text")]
        public Text2DIRS Text { get; set; }
    }

    [JsonObject(Title = "Descriptions")]
    public class DescriptionsDIRS
    {

        [JsonProperty("Description")]
        public DescriptionDIRS[] Description { get; set; }
    }

    public class Airport
    {

        [JsonProperty("AirportOrCityCode")]
        public string AirportOrCityCode { get; set; }

        [JsonProperty("DirectionId")]
        public string DirectionId { get; set; }

        [JsonProperty("DistanceFromHotel")]
        public int DistanceFromHotel { get; set; }

        [JsonProperty("UOM")]
        public string UOM { get; set; }

        [JsonProperty("AirportOrCityDescription")]
        public string AirportOrCityDescription { get; set; }

        [JsonProperty("AirportOrCityCountryCode")]
        public string AirportOrCityCountryCode { get; set; }

        [JsonProperty("Primary")]
        public bool Primary { get; set; }
    }

    public class Airports
    {

        [JsonProperty("Airport")]
        public Airport[] Airport { get; set; }
    }

    public class CreditCard
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class AcceptedCreditCards
    {

        [JsonProperty("CreditCard")]
        public CreditCard[] CreditCard { get; set; }
    }

    public class HotelDescriptiveInfo
    {

        [JsonProperty("HotelInfo")]
        public HotelInfoDIRS HotelInfo { get; set; }

        [JsonProperty("PropertyInfo")]
        public PropertyInfo PropertyInfo { get; set; }

        [JsonProperty("LocationInfo")]
        public LocationInfo LocationInfo { get; set; }

        [JsonProperty("Amenities")]
        public Amenities Amenities { get; set; }

        [JsonProperty("Descriptions")]
        public DescriptionsDIRS Descriptions { get; set; }

        [JsonProperty("Airports")]
        public Airports Airports { get; set; }

        [JsonProperty("AcceptedCreditCards")]
        public AcceptedCreditCards AcceptedCreditCards { get; set; }
    }

    public class HotelDescriptiveInfos
    {

        [JsonProperty("HotelDescriptiveInfo")]
        public HotelDescriptiveInfo[] HotelDescriptiveInfo { get; set; }
    }

    public class GetHotelDescriptiveInfoRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResultsDIRS ApplicationResults { get; set; }

        [JsonProperty("HotelDescriptiveInfos")]
        public HotelDescriptiveInfos HotelDescriptiveInfos { get; set; }
    }

    [JsonObject(Title = "Link")]
    public class Link_1
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

}
