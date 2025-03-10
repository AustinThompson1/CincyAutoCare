using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);
        public Customer GetCustomerById(int customerId);
        public List<Customer> GetAllCustomers();
        public void DeleteCustomer(int customerId);
        public void UpdateCustomer(Customer customer);
        public void ResetDatabase();
    }
}
