using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _dbContext;
        public CustomerRepository()
        {
            _dbContext = new CustomerContext();
        }
        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int customerId)
        {
            try
            {
                return _dbContext.Customers.SingleOrDefault(x => x.CustomerId == customerId)
                ?? throw new Exception("CustomerId does not exist");
            }
            catch (Exception)
            {
                Console.WriteLine("CustomerId does not exist");
                return null;
            }
        }

        public List<Customer> GetAllCustomers() => _dbContext.Customers.ToList();
        public void UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }
        public void DeleteCustomer(int customerId)
        {
            var customer = _dbContext.Customers.SingleOrDefault(x => x.CustomerId == customerId);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }
        public void ResetDatabase()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
        }
    }
}
