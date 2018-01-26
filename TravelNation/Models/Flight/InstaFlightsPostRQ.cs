using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelNation.Interface;

namespace TravelNation.Models.Flight
{
    public class InstaFlightsPostRQ : IInstaFlightsData
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
