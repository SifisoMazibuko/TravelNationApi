using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNationApi.Models.TravelFusion
{
    public class TravelFusionGetFlightsRequest
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<int> Ages { get; set; }
        public int BagsToCheckIn { get; set; }
        public string Currency { get; set; }
    }
}
