using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Models
{
    public class Tinting
    {
        public int TintingId { get; set; }
        public string? TintingType { get; set; }
        public int? TintPercent { get; set; }
        public decimal? CostOfWindowTint { get; set; }
        public string? TintAmount { get; set; }
        public string? HeadlightsAreTinted { get; set; } = "false";
        public string? TaillightsAreTinted { get; set; } = "true";
        public decimal? CostOfLightsTint { get; set; }

        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
    }
}
