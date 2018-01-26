using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using TravelNationApi.Models.Searching.Flight;
using TravelNationApi.Models.Searching.Flight.Sabre;

namespace TravelNationApi.Controllers
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

        /// <summary>
        ///  Search a flight using destination, origin and date
        /// </summary>
        /// <remarks>
        /// sample request:
        /// 
        ///     POST api/flight/search
        ///     {
        ///         "origin": "JNB",
        ///         "destination": "DUR",
        ///         "departureDate": "2018-01-23",
        ///         "returnDate": "2018-01-24"
        ///     }
        /// 
        /// </remarks>
        /// <param name="model">object containing search information</param>
        /// 
        /// <returns>matching flight(s)</returns>
        [HttpPost]
        [Route("insta_flights_search/search")]
        public IActionResult InstaFlightsSearch([FromBody]SearchDto model)
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
        [Route("insta_flights_search")]
        public IActionResult InstaFlightsSearch()
        {
            return this.View();
        }
    }
}