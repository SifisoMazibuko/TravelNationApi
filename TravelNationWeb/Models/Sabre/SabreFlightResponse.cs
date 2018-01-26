using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelNationWeb.Models.Sabre
{

    public class SabreFlightResponse
    {
        public List<PricedItinerary> PricedItineraries { get; set; }
        public string ReturnDateTime { get; set; }
        public string DepartureDateTime { get; set; }
        public string DestinationLocation { get; set; }
        public string OriginLocation { get; set; }
    }

    public class DepartureAirport
    {
        public string LocationCode { get; set; }
    }

    public class ArrivalAirport
    {
        public string LocationCode { get; set; }
    }

    public class MarketingAirline
    {
        public string Code { get; set; }
    }

    public class ArrivalTimeZone
    {
        public int GMTOffset { get; set; }
    }

    public class ETicket
    {
        public bool Ind { get; set; }
    }

    public class TPAExtensions
    {
        public ETicket eTicket { get; set; }
    }

    public class Equipment
    {
        public int AirEquipType { get; set; }
    }

    public class OperatingAirline
    {
        public string CompanyShortName { get; set; }
        public int FlightNumber { get; set; }
        public string Code { get; set; }
    }

    public class DepartureTimeZone
    {
        public int GMTOffset { get; set; }
    }

    public class FlightSegment
    {
        public DepartureAirport DepartureAirport { get; set; }
        public ArrivalAirport ArrivalAirport { get; set; }
        public MarketingAirline MarketingAirline { get; set; }
        public ArrivalTimeZone ArrivalTimeZone { get; set; }
        public TPAExtensions TPA_Extensions { get; set; }
        public int StopQuantity { get; set; }
        public int ElapsedTime { get; set; }
        public string ResBookDesigCode { get; set; }
        public string MarriageGrp { get; set; }
        public Equipment Equipment { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int FlightNumber { get; set; }
        public OperatingAirline OperatingAirline { get; set; }
        public DepartureTimeZone DepartureTimeZone { get; set; }
    }

    public class OriginDestinationOption
    {
        public List<FlightSegment> FlightSegment { get; set; }
        public int ElapsedTime { get; set; }
    }

    public class OriginDestinationOptions
    {
        public List<OriginDestinationOption> OriginDestinationOption { get; set; }
    }

    public class AirItinerary
    {
        public OriginDestinationOptions OriginDestinationOptions { get; set; }
        public string DirectionInd { get; set; }
    }

    public class ValidatingCarrier
    {
        public string Code { get; set; }
    }

    public class TPAExtensions2
    {
        public ValidatingCarrier ValidatingCarrier { get; set; }
    }

    public class FareBasisCode
    {
        public string BookingCode { get; set; }
        public string DepartureAirportCode { get; set; }
        public bool AvailabilityBreak { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string content { get; set; }
    }

    public class FareBasisCodes
    {
        public List<FareBasisCode> FareBasisCode { get; set; }
    }

    public class PassengerTypeQuantity
    {
        public int Quantity { get; set; }
        public string Code { get; set; }
    }

    public class FareConstruction
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class TotalFare
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class TotalTax
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class Tax
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string TaxCode { get; set; }
        public double Amount { get; set; }
    }

    public class Taxes
    {
        public TotalTax TotalTax { get; set; }
        public List<Tax> Tax { get; set; }
    }

    public class BaseFare
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class EquivFare
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class PassengerFare
    {
        public FareConstruction FareConstruction { get; set; }
        public TotalFare TotalFare { get; set; }
        public Taxes Taxes { get; set; }
        public BaseFare BaseFare { get; set; }
        public EquivFare EquivFare { get; set; }
    }

    public class Endorsements
    {
        public bool NonRefundableIndicator { get; set; }
    }

    public class PTCFareBreakdown
    {
        public FareBasisCodes FareBasisCodes { get; set; }
        public PassengerTypeQuantity PassengerTypeQuantity { get; set; }
        public PassengerFare PassengerFare { get; set; }
        public Endorsements Endorsements { get; set; }
    }

    public class PTCFareBreakdowns
    {
        public PTCFareBreakdown PTC_FareBreakdown { get; set; }
    }

    public class Cabin
    {
        [JsonProperty("Cabin")]
        public string Cabinn { get; set; }
    }

    public class SeatsRemaining
    {
        public bool BelowMin { get; set; }
        public int Number { get; set; }
    }

    public class TPAExtensions3
    {
        public Cabin Cabin { get; set; }
        public SeatsRemaining SeatsRemaining { get; set; }
    }

    public class FareInfo
    {
        public TPAExtensions3 TPA_Extensions { get; set; }
        public string FareReference { get; set; }
    }

    public class FareInfos
    {
        public List<FareInfo> FareInfo { get; set; }
    }

    public class DivideInParty
    {
        public bool Indicator { get; set; }
    }

    public class TPAExtensions4
    {
        public DivideInParty DivideInParty { get; set; }
    }

    public class FareConstruction2
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class TotalFare2
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class Tax2
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string TaxCode { get; set; }
        public string Amount { get; set; }
    }

    public class Taxes2
    {
        public List<Tax2> Tax { get; set; }
    }

    public class BaseFare2
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class EquivFare2
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string Amount { get; set; }
    }

    public class ItinTotalFare
    {
        public FareConstruction2 FareConstruction { get; set; }
        public TotalFare2 TotalFare { get; set; }
        public Taxes2 Taxes { get; set; }
        public BaseFare2 BaseFare { get; set; }
        public EquivFare2 EquivFare { get; set; }
    }

    public class AirItineraryPricingInfo
    {
        public PTCFareBreakdowns PTC_FareBreakdowns { get; set; }
        public FareInfos FareInfos { get; set; }
        public TPAExtensions4 TPA_Extensions { get; set; }
        public ItinTotalFare ItinTotalFare { get; set; }
    }

    public class TicketingInfo
    {
        public string TicketType { get; set; }
    }

    public class PricedItinerary
    {
        public AirItinerary AirItinerary { get; set; }
        public TPAExtensions2 TPA_Extensions { get; set; }
        public int SequenceNumber { get; set; }
        public AirItineraryPricingInfo AirItineraryPricingInfo { get; set; }
        public TicketingInfo TicketingInfo { get; set; }
    }
}