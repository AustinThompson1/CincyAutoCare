using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data
{
    public class Tinting
    {
        public Int32 TintingId { get; set; }
        public string TintingType { get; set; }
        public Int32? TintPercent { get; set; }
        public decimal? CostOfWindowTint { get; set; }
        public string TintAmount { get; set; }
        public bool HeadlightsAreTinted { get; set; }
        public bool TaillightsAreTinted { get; set; }
        public decimal? CostOfLightsTint { get; set; }
        public Int32 CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
