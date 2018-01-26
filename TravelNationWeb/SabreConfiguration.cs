using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelNationWeb
{
    public class SabreConfiguration
    {
        public string TestBaseUrl { get; set; }
        public string LiveBaseUrl { get; set; }
        public string CountryCode { get; set; }
        public string TestToken { get; set; }
    }
}