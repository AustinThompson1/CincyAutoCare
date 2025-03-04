using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareCare.Data
{
    public class Customer
    {
        public Int32 CustomerId { get; set; }
        public string CustomerName { get; set; }
        public PhoneAttribute? PhoneNumber { get; set; }
        public EmailAddressAttribute? Email { get; set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateOnly ServiceDate { get; set; }
        public bool VehicleIsDetailed { get; set; }
        public bool VehicleIsTinted { get; set; }
        public decimal TotalCostOfServices { get; set; }
        public decimal Overhead { get; set; }
        public decimal AmountChargedToCustomer { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; }

        
    }
}
