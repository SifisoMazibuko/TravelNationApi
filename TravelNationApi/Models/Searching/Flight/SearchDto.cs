using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.Searching.Flight
{
    public class SearchDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
