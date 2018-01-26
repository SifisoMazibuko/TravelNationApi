using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.TravelFusion
{
    public class TravelFusionGetFlightsResponse
    {
        public string Sid { get; set; }
        public ResultInfo ResultInfo { get; set; }
        public List<FlightOffer> Results { get; set; }
    }

    public class FlightOffer
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public Price BillingPrice { get; set; }
        public Price Price { get; set; }

        public Out Out { get; set; }
        public Return Return { get; set; }
    }
    
    public class Price
    {
        public string Currency { get; set; }
        public decimal LagguageCharge { get; set; }
        public decimal Cost { get; set; }
    }

    public class Out
    {
        public string Orig { get; set; }
        public string Dest { get; set; }
        public DateTime Dep { get; set; }
        public DateTime Arr { get; set; }
        public int Changes { get; set; }
        public TimeSpan Duration { get; set; }

        public List<SegmentEntry> Segment { get; set; }
    }

    public class Return
    {
        public string Orig { get; set; }
        public string Dest { get; set; }
        public DateTime Dep { get; set; }
        public DateTime Arr { get; set; }
        public int Changes { get; set; }
        public TimeSpan Duration { get; set; }

        public List<SegmentEntry> Segment { get; set; }
    }

    public class SegmentEntry
    {
        public string Dest { get; set; }
        public string Operator { get; set; }
    }

    public class ResultInfo
    {
        public int CompleteConnections { get; set; }
        public int SupplierConnections { get; set; }
        public int Suppliers { get; set; }
        public int TotalResults { get; set; }

        public List<Supplier> SupplierResultInfo { get; set; }
        public SystemInfo SystemInfo { get; set; }
    }

    public class SystemInfo
    {
        public int Suppliers { get; set; }
    }

    public class Supplier
    {
        public string Name { get; set; }
        public int CompleteConnections { get; set; }
        public int SupplierConnections { get; set; }
        public int TotalResults { get; set; }
    }
}
