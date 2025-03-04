using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data
{
    public class Vehicles
    {
        public Int32 VehiclesId { get; set; }
        public Int32 VehiclesCount { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public Int32 VehicleYear { get; set; }

        public string ServiceLocation { get; set; }
        public Int32 CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
