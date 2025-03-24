using CareCare.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Logic
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);
        public Customer GetCustomerById(int id);
        public List<Customer> GetAllCustomers();
        public void DeleteCustomer(int id);
        public void UpdateCustomer(Customer customer);
        public void ResetDatabase();
    }
}
