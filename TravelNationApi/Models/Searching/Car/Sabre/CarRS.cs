    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Car.Sabre
{
    public class CarRS
    {
        public OTAVehAvailRateRS OTA_VehAvailRateRS { get; set; }
        public List<Link> Links { get; set; }
    }

    public class Success
    {
        public DateTime timeStamp { get; set; }
    }

    public class ApplicationResults
    {
        public List<Success> Success { get; set; }
    }

    public class HeaderInfo
    {
        public List<string> Text { get; set; }
    }

    public class DropOffLocationDetails
    {
        public string LocationCode { get; set; }
    }

    public class LocationDetails
    {
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
    }

    public class VehRentalCore
    {
        public string NumDays { get; set; }
        public string NumHours { get; set; }
        public string PickUpDateTime { get; set; }
        public string ReturnDateTime { get; set; }
        public DropOffLocationDetails DropOffLocationDetails { get; set; }
        public LocationDetails LocationDetails { get; set; }
    }

    public class Vehicle
    {
        public List<string> VehType { get; set; }
    }

    public class RentalRate
    {
        public string AvailabilityStatus { get; set; }
        public string RateCode { get; set; }
        public string STM_RatePlan { get; set; }
        public Vehicle Vehicle { get; set; }
    }

    public class Day
    {
        public string CurrencyCode { get; set; }
        public string MileageAllowance { get; set; }
        public string Rate { get; set; }
    }

    public class Hour
    {
        public string CurrencyCode { get; set; }
        public string MileageAllowance { get; set; }
        public string Rate { get; set; }
    }

    public class AdditionalDayHour
    {
        public Day Day { get; set; }
        public Hour Hour { get; set; }
    }

    public class Commission
    {
        public string Amount { get; set; }
        public string Percent { get; set; }
    }

    public class Mileage
    {
        public string Allowance { get; set; }
        public string CurrencyCode { get; set; }
        public string ExtraMileageCharge { get; set; }
    }

    public class SpecialEquipTotalCharge
    {
        public string CurrencyCode { get; set; }
    }

    public class TotalCharge
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string RateAssured { get; set; }
    }

    public class VehicleCharge
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string GuaranteeInd { get; set; }
        public AdditionalDayHour AdditionalDayHour { get; set; }
        public Commission Commission { get; set; }
        public Mileage Mileage { get; set; }
        public SpecialEquipTotalCharge SpecialEquipTotalCharge { get; set; }
        public TotalCharge TotalCharge { get; set; }
        public string SellGuaranteeReq { get; set; }
    }

    public class VehicleCharges
    {
        public VehicleCharge VehicleCharge { get; set; }
    }

    public class VehAvailCore
    {
        public RentalRate RentalRate { get; set; }
        public VehicleCharges VehicleCharges { get; set; }
    }

    public class Vendor
    {
        public string Code { get; set; }
        public string CompanyShortName { get; set; }
        public string CounterLocation { get; set; }
        public string ParticipationLevel { get; set; }
    }

    public class VehVendorAvail
    {
        public string RPH { get; set; }
        public VehAvailCore VehAvailCore { get; set; }
        public Vendor Vendor { get; set; }
    }

    public class VehVendorAvails
    {
        public List<VehVendorAvail> VehVendorAvail { get; set; }
    }

    public class VehAvailRSCore
    {
        public HeaderInfo HeaderInfo { get; set; }
        public VehRentalCore VehRentalCore { get; set; }
        public VehVendorAvails VehVendorAvails { get; set; }
    }

    public class OTAVehAvailRateRS
    {
        public string Version { get; set; }
        public ApplicationResults ApplicationResults { get; set; }
        public VehAvailRSCore VehAvailRSCore { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }
}
