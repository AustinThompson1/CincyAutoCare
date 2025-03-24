using CareCare.Data.Logic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareCare.Data.Models
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string ServiceDate { get; set; }
        public string? VehicleIsDetailed { get; set; } = "false";
        public string? VehicleIsTinted { get; set; } = "false";
        public decimal TotalCostOfServices { get; set; }
        public decimal Overhead { get; set; }
        public decimal AmountChargedToCustomer { get; set; }
        //public Tinting Tinting { get; set; }


}
}
