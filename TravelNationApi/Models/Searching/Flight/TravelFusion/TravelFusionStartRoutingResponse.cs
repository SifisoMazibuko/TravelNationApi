using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelNationApi.Models.Searching.Flight.TravelFusion
{
    [XmlRoot(ElementName = "CommandList")]
    public class TravelFusionStartRoutingResponse
    {
        [XmlElement(ElementName = "StartRouting")]
        public StartRoutingResponse StartRouting { get; set; }
    }

    [XmlRoot(ElementName = "Origin")]
    public class OriginResponse
    {
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "Destination")]
    public class DestinationResponse
    {
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "RequestedLocations")]
    public class RequestedLocations
    {
        [XmlElement(ElementName = "Origin")]
        public OriginResponse Origin { get; set; }
        [XmlElement(ElementName = "Destination")]
        public DestinationResponse Destination { get; set; }
    }

    [XmlRoot(ElementName = "Router")]
    public class Router
    {
        [XmlElement(ElementName = "Supplier")]
        public string Supplier { get; set; }
        [XmlElement(ElementName = "Complete")]
        public string Complete { get; set; }
        [XmlElement(ElementName = "RequestedLocations")]
        public RequestedLocations RequestedLocations { get; set; }
    }

    [XmlRoot(ElementName = "RouterList")]
    public class RouterList
    {
        [XmlElement(ElementName = "Router")]
        public List<Router> Router { get; set; }
    }

    [XmlRoot(ElementName = "StartRouting")]
    public class StartRoutingResponse
    {
        [XmlElement(ElementName = "RoutingId")]
        public string RoutingId { get; set; }
        [XmlElement(ElementName = "RouterList")]
        public RouterList RouterList { get; set; }
    }
}
