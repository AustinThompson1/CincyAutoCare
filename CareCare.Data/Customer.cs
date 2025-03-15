using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareCare.Data
{
    public class Customer : ICustomer
    {
        public Int32 CustomerId { get; set; }
        public string CustomerName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string ServiceDate { get; set; }
        public bool VehicleIsDetailed { get; set; } = false;
        public bool VehicleIsTinted { get; set; } = false;
        public decimal TotalCostOfServices { get; set; }
        public decimal Overhead { get; set; }
        public decimal AmountChargedToCustomer { get; set; }
        //public ICollection<Vehicles> Vehicles { get; set; }

        
    }
}
