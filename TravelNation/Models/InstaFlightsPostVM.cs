using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNation.Models
{
    public class InstaFlightsPostVM
    {
        public string RequestUrl { get; set; }

        public string ResponseJson { get; set; }

        public string ErrorMessage { get; set; }

        public string ResponseDotNet { get; set; }
    }
}
