using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNation.Models.Flight
{
    public class SearchFightDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
