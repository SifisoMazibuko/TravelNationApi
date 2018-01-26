using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelNationWeb.Interface;

namespace TravelNationWeb.Models.Flight
{
    public class InstaFlightsPostRQ : IInstaFlightsData
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}