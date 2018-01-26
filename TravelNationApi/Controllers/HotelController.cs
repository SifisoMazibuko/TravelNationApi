using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using TravelNationApi.Models.Searching.Hotel.Sabre;
using Newtonsoft.Json;
using TravelNationApi.Models.Searching.Hotel;
using System.Net.Http;
using System.Text;

namespace TravelNationApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Hotel")]
    public class HotelController : Controller
    {
        private SabreConfiguration sabreConfig;

        public HotelController(IOptions<SabreConfiguration> sabreConfig)
        {
            this.sabreConfig = sabreConfig.Value;
        }

        [HttpPost]
        [Route("hotels/list")]
        public async Task<IActionResult> GetHotelList([FromBody]HotelListRQ model)
        {
            var url = "v1.0.0/shop/hotels/list?mode=list";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(model);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelListRS>(responseBody));
        }

        [HttpPost]
        [Route("hotels/image")]
        public async Task<IActionResult> GetHotelImage([FromBody]HotelImageRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/image?mode=image";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelImageRS>(responseBody));
        }

        [HttpPost]
        [Route("hotels/media")]
        public async Task<IActionResult> GetHotelMedia([FromBody]HotelMediaRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/media";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelMediaRS>(responseBody));   
        }

        [HttpPost]
        [Route("hotels/chain")]
        public async Task<IActionResult> GetHotelChain([FromBody]HotelChainRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/chain?mode=chain";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelChainRS>(responseBody));
        }

        [HttpPost]
        [Route("hotels/content/change")]
        public async Task<IActionResult> GetHotelContentChange([FromBody]HotelContentChangeRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/content/change?mode=change";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelContentChangeRS>(responseBody));
        }

        [HttpPost]
        [Route("hotels/content")]
        public async Task<IActionResult> GetHotelContent([FromBody]HotelContentRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/content?mode=content";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelContentRS>(responseBody));
        }


        [HttpPost]
        [Route("hotels/description/info")]
        public async Task<IActionResult> GetHotelDescriptiveInfo([FromBody]HotelDescriptiveInfoRQ requestModel)
        {
            var url = "v1.0.0/shop/hotels/description?mode=description";
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(requestModel);
            string responseBody;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sabreConfig.TestBaseUrl);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sabreConfig.TestToken}");

                response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            }
            responseBody = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<HotelDescriptiveInfoRS>(responseBody));
        }
    }
}