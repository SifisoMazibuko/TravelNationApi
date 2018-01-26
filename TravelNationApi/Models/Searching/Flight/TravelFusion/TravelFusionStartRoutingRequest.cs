using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelNationApi.Models.Searching.Flight.TravelFusion
{
    [XmlRoot(ElementName = "CommandList")]
    public class TravelFusionStartRoutingRequest
    {
        [XmlElement(ElementName = "StartRouting")]
        public StartRoutingRequest StartRouting { get; set; }
    }

    [XmlRoot(ElementName = "Origin")]
    public class OriginRequest
    {
        [XmlElement(ElementName = "Descriptor")]
        public string Descriptor { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "Destination")]
    public class DestinationRequest
    {
        [XmlElement(ElementName = "Descriptor")]
        public string Descriptor { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Radius")]
        public string Radius { get; set; }
    }

    [XmlRoot(ElementName = "OutwardDates")]
    public class OutwardDates
    {
        [XmlElement(ElementName = "DateOfSearch")]
        public string DateOfSearch { get; set; }
    }

    [XmlRoot(ElementName = "ReturnDates")]
    public class ReturnDates
    {
        [XmlElement(ElementName = "DateOfSearch")]
        public string DateOfSearch { get; set; }
    }

    [XmlRoot(ElementName = "Traveller")]
    public class Traveller
    {
        [XmlElement(ElementName = "Age")]
        public string Age { get; set; }
    }

    [XmlRoot(ElementName = "TravellerList")]
    public class TravellerList
    {
        [XmlElement(ElementName = "Traveller")]
        public Traveller Traveller { get; set; }
    }

    [XmlRoot(ElementName = "StartRouting")]
    public class StartRoutingRequest
    {
        [XmlElement(ElementName = "XmlLoginId")]
        public string XmlLoginId { get; set; }

        [XmlElement(ElementName = "LoginId")]
        public string LoginId { get; set; }

        [XmlElement(ElementName = "Mode")]
        public string Mode { get; set; }

        [XmlElement(ElementName = "Origin")]
        public OriginRequest Origin { get; set; }

        [XmlElement(ElementName = "Destination")]
        public DestinationResponse Destination { get; set; }

        [XmlElement(ElementName = "OutwardDates")]
        public OutwardDates OutwardDates { get; set; }

        [XmlElement(ElementName = "ReturnDates", IsNullable = true)]
        public ReturnDates ReturnDates { get; set; }

        [XmlElement(ElementName = "MaxChanges")]
        public string MaxChanges { get; set; }

        [XmlElement(ElementName = "MaxHops")]
        public string MaxHops { get; set; }

        [XmlElement(ElementName = "Timeout")]
        public string Timeout { get; set; }

        [XmlElement(ElementName = "TravellerList")]
        public TravellerList TravellerList { get; set; }

        [XmlElement(ElementName = "IncrementalResults")]
        public string IncrementalResults { get; set; }
    }
}
