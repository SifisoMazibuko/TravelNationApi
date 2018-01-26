using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelNationWeb.Models.Flight;
using TravelNationWeb.Models.Sabre;

namespace TravelNationWeb.Controllers
{
    public class FlightController : Controller
    {
        private SabreConfiguration sabreConfig;

        public FlightController(IOptions<SabreConfiguration> sabreConfig)
        {
            this.sabreConfig = sabreConfig.Value;
        }
        [HttpPost]
        public ActionResult InstaFlightsSearch(InstaFlightsPostRQ model)
        {
            var client = new RestClient(sabreConfig.TestBaseUrl);

            var url = $"v1/shop/flights?origin={model.Origin}&destination={model.Destination}&departuredate={model.DepartureDate}&returndate={model.ReturnDate}&onlineitinerariesonly=N&limit=10&offset=1&eticketsonly=N&sortby=totalfare&order=asc&sortby2=departuretime&order2=asc&pointofsalecountry=ZA";

            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Authorization", $"Bearer {sabreConfig.TestToken}");

            var response = client.Execute(request);

            var returnObject = JsonConvert.DeserializeObject<SabreFlightResponse>(response.Content);

           // return Ok(returnObject.PricedItineraries.Select(pi => pi.AirItinerary)/*.Select(ai => ai.OriginDestinationOptions)*/);

            return View();
        }
        [HttpGet]
        public ActionResult InstaFlightsSearchForm()
        {
            return View();
        }
    }
}