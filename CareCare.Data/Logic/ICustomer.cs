using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Logic
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string ServiceDate { get; set; }
        public string? VehicleIsDetailed { get; set; }
        public string? VehicleIsTinted { get; set; }
        public decimal TotalCostOfServices { get; set; }
        public decimal Overhead { get; set; }
        public decimal AmountChargedToCustomer { get; set; }
        //public ICollection<Vehicles> Vehicles { get; set; }
    }
}
