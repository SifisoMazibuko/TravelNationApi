using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Helpers.Sabre
{
    public class AddressRef
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string StateProv { get; set; }
        public string CountryCode { get; set; }
    }

    public class GeoRef
    {
        public string Category { get; set; }
        public double Radius { get; set; }
        public string UOM { get; set; }
        public int MaxResults { get; set; }
        public int OffSet { get; set; }
        public AddressRef AddressRef { get; set; }
    }

    public class GeoSearchRQ
    {
        public string version { get; set; }
        public GeoRef GeoRef { get; set; }
    }

    //public class RootObject
    //{
    //    public GeoSearchRQ GeoSearchRQ { get; set; }
    //}
}
