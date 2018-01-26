using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Hotel.Sabre
{
    [JsonObject(Title = "Success")]
    public class SuccessCRS
    {

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }

    [JsonObject(Title = "ApplicationResults")]
    public class ApplicationResultsCRS
    {

        [JsonProperty("Success")]
        public SuccessCRS[] Success { get; set; }
    }

    [JsonObject(Title = "HotelInfo")]
    public class HotelInfoCRS
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

    public class PropertyType
    {

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "PropertyTypeInfo")]
    public class PropertyTypeInfoCRS
    {

        [JsonProperty("PropertyType")]
        public PropertyType[] PropertyType { get; set; }
    }

    public class PropertyFeature
    {

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "PropertyFeatures")]
    public class PropertyFeaturesCRS
    {

        [JsonProperty("PropertyFeature")]
        public PropertyFeature[] PropertyFeature { get; set; }
    }

    [JsonObject(Title = "Text")]
    public class TextCRS
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "Policy")]
    public class PolicyCRS
    {

        [JsonProperty("Text")]
        public TextCRS Text { get; set; }
    }

    [JsonObject(Title = "Policies")]
    public class PoliciesCRS
    {

        [JsonProperty("Policy")]
        public PolicyCRS[] Policy { get; set; }
    }

    [JsonObject(Title = "PropertyQuality")]
    public class PropertyQualityCRS
    {

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "PropertyQualityInfo")]
    public class PropertyQualityInfoCRS
    {

        [JsonProperty("PropertyQuality")]
        public PropertyQualityCRS[] PropertyQuality { get; set; }
    }

    [JsonObject(Title = "PropertyTax")]
    public class PropertyTaxCRS
    {

        [JsonProperty("Info")]
        public string Info { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "PropertyTaxes")]
    public class PropertyTaxesCRS
    {

        [JsonProperty("PropertyTax")]
        public PropertyTaxCRS[] PropertyTax { get; set; }
    }

    public class RoomTrait
    {

        [JsonProperty("Info")]
        public string Info { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "RoomTraits")]
    public class RoomTraitsCRS
    {

        [JsonProperty("RoomTrait")]
        public RoomTrait[] RoomTrait { get; set; }
    }

    [JsonObject(Title = "Amenity")]
    public class AmenityCRS
    {

        [JsonProperty("Info")]
        public string Info { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "RequestableAmenities")]
    public class RequestableAmenitiesCRS
    {

        [JsonProperty("Amenity")]
        public AmenityCRS[] Amenity { get; set; }
    }

    [JsonObject(Title = "PropertyInfo")]
    public class PropertyInfoCRS
    {

        [JsonProperty("Floors")]
        public string Floors { get; set; }

        [JsonProperty("Rooms")]
        public string Rooms { get; set; }

        [JsonProperty("PropertyTypeInfo")]
        public PropertyTypeInfoCRS PropertyTypeInfo { get; set; }

        [JsonProperty("PropertyFeatures")]
        public PropertyFeaturesCRS PropertyFeatures { get; set; }

        [JsonProperty("Policies")]
        public PoliciesCRS Policies { get; set; }

        [JsonProperty("PropertyQualityInfo")]
        public PropertyQualityInfoCRS PropertyQualityInfo { get; set; }

        [JsonProperty("PropertyTaxes")]
        public PropertyTaxesCRS PropertyTaxes { get; set; }

        [JsonProperty("RoomTraits")]
        public RoomTraitsCRS RoomTraits { get; set; }

        [JsonProperty("RequestableAmenities")]
        public RequestableAmenitiesCRS RequestableAmenities { get; set; }
    }

    [JsonObject(Title = "StateProv")]
    public class StateProvCRS
    {

        [JsonProperty("StateCode")]
        public string StateCode { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "CountryName")]
    public class CountryNameCRS
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class AddressCRS
    {

        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("CityName")]
        public string CityName { get; set; }

        [JsonProperty("StateProv")]
        public StateProvCRS StateProv { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("CountryName")]
        public CountryNameCRS CountryName { get; set; }

        [JsonProperty("AddressLine2")]
        public string AddressLine2 { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class ContactCRS
    {

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class LocationInfoCRS
    {

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Address")]
        public AddressCRS Address { get; set; }

        [JsonProperty("Contact")]
        public ContactCRS Contact { get; set; }
    }

    public class Amenity2
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AdditionalCharge")]
        public bool? AdditionalCharge { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class AmenitiesCRS
    {

        [JsonProperty("Amenity")]
        public Amenity2[] Amenity { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class Text2CRS
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class DescriptionCRS
    {

        [JsonProperty("Text")]
        public Text2CRS Text { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class DescriptionsCRS
    {

        [JsonProperty("Description")]
        public DescriptionCRS[] Description { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class AirportCRS
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

        [JsonProperty("AirportOrCityStateCode")]
        public string AirportOrCityStateCode { get; set; }

        [JsonProperty("AirportOrCityCountryCode")]
        public string AirportOrCityCountryCode { get; set; }

        [JsonProperty("Primary")]
        public bool Primary { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class AirportsCRS
    {

        [JsonProperty("Airport")]
        public AirportCRS[] Airport { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class CreditCardCRS
    {

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class AcceptedCreditCardsCRS
    {

        [JsonProperty("CreditCard")]
        public CreditCardCRS[] CreditCard { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class HotelDescriptiveInfoCRS
    {

        [JsonProperty("PropertyInfo")]
        public PropertyInfoCRS PropertyInfo { get; set; }

        [JsonProperty("LocationInfo")]
        public LocationInfoCRS LocationInfo { get; set; }

        [JsonProperty("Amenities")]
        public AmenitiesCRS Amenities { get; set; }

        [JsonProperty("Descriptions")]
        public DescriptionsCRS Descriptions { get; set; }

        [JsonProperty("Airports")]
        public AirportsCRS Airports { get; set; }

        [JsonProperty("AcceptedCreditCards")]
        public AcceptedCreditCardsCRS AcceptedCreditCards { get; set; }
    }

    public class HotelContentInfo
    {

        [JsonProperty("HotelInfo")]
        public HotelInfoCRS HotelInfo { get; set; }

        [JsonProperty("HotelDescriptiveInfo")]
        public HotelDescriptiveInfoCRS HotelDescriptiveInfo { get; set; }
    }

    public class HotelContentInfos
    {

        [JsonProperty("HotelContentInfo")]
        public HotelContentInfo[] HotelContentInfo { get; set; }
    }

    public class GetHotelContentRS
    {

        [JsonProperty("ApplicationResults")]
        public ApplicationResultsCRS ApplicationResults { get; set; }

        [JsonProperty("HotelContentInfos")]
        public HotelContentInfos HotelContentInfos { get; set; }
    }

    [JsonObject(Title = "Address")]
    public class LinkCRS
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class HotelContentRS
    {

        [JsonProperty("GetHotelContentRS")]
        public GetHotelContentRS GetHotelContentRS { get; set; }

        [JsonProperty("Links")]
        public LinkCRS[] Links { get; set; }
    }

}
