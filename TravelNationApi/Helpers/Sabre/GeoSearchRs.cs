using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Helpers.Sabre
{
    public class Success
    {
        public DateTime timeStamp { get; set; }
    }

    public class ApplicationResults
    {
        public List<Success> Success { get; set; }
    }

    public class Attribute
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class GeoSearchResult
    {
        public double Distance { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Attribute Attribute { get; set; }
    }

    public class GeoSearchResults
    {
        public double Radius { get; set; }
        public string UOM { get; set; }
        public string Category { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int MaxSearchResults { get; set; }
        public int OffSet { get; set; }

        public List<GeoSearchResult> GeoSearchResult { get; set; }
    }

    public class GeoSearchRS
    {
        public ApplicationResults ApplicationResults { get; set; }
        public GeoSearchResults GeoSearchResults { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class RootObject
    {
        public GeoSearchRS GeoSearchRS { get; set; }
        public List<Link> Links { get; set; }
    }
}
