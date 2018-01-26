using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using Newtonsoft.Json;
using TravelNationApi.Models.Searching.Car;
using System.Net.Http;
using System.Text;
using TravelNationApi.Models.Searching.Car.Sabre;

namespace TravelNationApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Car")]
    public class CarController : Controller
    {
        private SabreConfiguration sabreConfig;

        public CarController(IOptions<SabreConfiguration> sabreConfig)
        {
            this.sabreConfig = sabreConfig.Value;
        }

        [HttpPost]
        [Route("cars")]
        public async Task<IActionResult> CarAvailabilityAsync([FromBody]CarRQ model)
        {
            var url = "v2.4.0/shop/cars";

            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(model);
            string responseBody;

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");
                
                response = await httpClient.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }

            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<CarRS>(responseBody));
        }
    }
}