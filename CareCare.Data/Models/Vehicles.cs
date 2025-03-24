using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Models
{
    public class Vehicles
    {
        public int VehiclesId { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleYear { get; set; }

        public string ServiceLocation { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
