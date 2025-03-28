﻿using CareCare.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Logic
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _dbContext;
        public CustomerRepository()
        {
            _dbContext = new CustomerContext();
            if (_dbContext == null)
            {
                throw new ArgumentNullException(nameof(_dbContext));
            }
        }
        public CustomerRepository(CustomerContext dbContext)
        {
            _dbContext = dbContext;
            if (_dbContext == null)
            {
                throw new ArgumentNullException(nameof(_dbContext));
            }
        }
        public void AddCustomer(Customer customer)
        {
            customer.Id = 0;
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            try
            {
                return _dbContext.Customers.SingleOrDefault(x => x.Id == id)
                ?? throw new Exception("CustomerId does not exist");
            }
            catch (Exception)
            {
                Console.WriteLine("CustomerId does not exist");
                return null;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> list =_dbContext.Customers.Cast<Customer>().ToList();
            return list;
        }
        public void UpdateCustomer(Customer customer)
        { 
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }
        public void DeleteCustomer(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(x => x.Id == id);
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
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }
    }
}
