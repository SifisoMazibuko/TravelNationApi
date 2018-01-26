using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelNation.Models.Flight;
using RestSharp;
using Newtonsoft.Json;
using TravelNationApi;
using Microsoft.Extensions.Options;
using TravelNationApi.Models.Searching.Flight.Sabre;

namespace TravelNation.Controllers
{
    [Produces("application/json")]
    [Route("api/Flight")]
    public class FlightController : Controller
    {
        private SabreConfiguration sabreConfig;

        public FlightController(IOptions<SabreConfiguration> sabreConfig)
        {
            this.sabreConfig = sabreConfig.Value;
        }
        [HttpPost]
        //[Route("insta_flights_search/search")]
        public IActionResult InstaFlightsSearch(SearchFightDto model)
        {
            var client = new RestClient(sabreConfig.TestBaseUrl);

            var url = $"v1/shop/flights?origin={model.Origin}&destination={model.Destination}&departuredate={model.DepartureDate}&returndate={model.ReturnDate}&onlineitinerariesonly=N&limit=10&offset=1&eticketsonly=N&sortby=totalfare&order=asc&sortby2=departuretime&order2=asc&pointofsalecountry=ZA";

            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Authorization", $"Bearer {sabreConfig.TestToken}");

            var response = client.Execute(request);

            var returnObject = JsonConvert.DeserializeObject<SabreSearchResponse>(response.Content);

            return Ok(returnObject.PricedItineraries.Select(pi => pi.AirItinerary)/*.Select(ai => ai.OriginDestinationOptions)*/);
        }

        [HttpGet]
        public IActionResult InstaFlightsSearchForm()
        {
            return this.View();
        }
    }
}