using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data
{
    public class TestCustomers
    {

        public static readonly List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                PhoneNumber = "513-777-7229",
                Email = "JohnDoe@gmail.com",
                ServiceDate = "2018-01-01",
                VehicleIsDetailed = false,
                VehicleIsTinted = true,
                TotalCostOfServices = 199.99m,
                Overhead = 50m,
                AmountChargedToCustomer = 200m
            },
            new Customer
            {
                CustomerId = 2,
                CustomerName = "Jane Smith",
                PhoneNumber = "513-888-7229",
                Email = "JaneSmith@gmail.com",
                ServiceDate = "2019-02-15",
                VehicleIsDetailed = true,
                VehicleIsTinted = false,
                TotalCostOfServices = 299.99m,
                Overhead = 60m,
                AmountChargedToCustomer = 300m
            },
            new Customer
            {
                CustomerId = 3,
                CustomerName = "Alice Johnson",
                PhoneNumber = "513-999-7229",
                Email = "AliceJohnson@gmail.com",
                ServiceDate = "2020-03-20",
                VehicleIsDetailed = false,
                VehicleIsTinted = true,
                TotalCostOfServices = 399.99m,
                Overhead = 70m,
                AmountChargedToCustomer = 400m
            },
            new Customer
            {
                CustomerId = 4,
                CustomerName = "Bob Brown",
                PhoneNumber = "513-777-1234",
                Email = "BobBrown@gmail.com",
                ServiceDate = "2021-04-10",
                VehicleIsDetailed = true,
                VehicleIsTinted = false,
                TotalCostOfServices = 499.99m,
                Overhead = 80m,
                AmountChargedToCustomer = 500m
            },
            new Customer
            {
                CustomerId = 5,
                CustomerName = "Charlie Davis",
                PhoneNumber = "513-888-5678",
                Email = "CharlieDavis@gmail.com",
                ServiceDate = "2022-05-05",
                VehicleIsDetailed = false,
                VehicleIsTinted = true,
                TotalCostOfServices = 599.99m,
                Overhead = 90m,
                AmountChargedToCustomer = 600m
            },
            new Customer
            {
                CustomerId = 6,
                CustomerName = "Diana Evans",
                PhoneNumber = "513-999-6789",
                Email = "DianaEvans@gmail.com",
                ServiceDate = "2023-06-25",
                VehicleIsDetailed = true,
                VehicleIsTinted = false,
                TotalCostOfServices = 699.99m,
                Overhead = 100m,
                AmountChargedToCustomer = 700m
            },
            new Customer
            {
                CustomerId = 7,
                CustomerName = "Eve Foster",
                PhoneNumber = "513-777-7890",
                Email = "EveFoster@gmail.com",
                ServiceDate = "2024-07-30",
                VehicleIsDetailed = false,
                VehicleIsTinted = true,
                TotalCostOfServices = 799.99m,
                Overhead = 110m,
                AmountChargedToCustomer = 800m
            },
            new Customer
            {
                CustomerId = 8,
                CustomerName = "Frank Green",
                PhoneNumber = "513-888-8901",
                Email = "FrankGreen@gmail.com",
                ServiceDate = "2025-08-15",
                VehicleIsDetailed = true,
                VehicleIsTinted = false,
                TotalCostOfServices = 899.99m,
                Overhead = 120m,
                AmountChargedToCustomer = 900m
            },
            new Customer
            {
                CustomerId = 9,
                CustomerName = "Grace Harris",
                PhoneNumber = "513-999-9012",
                Email = "GraceHarris@gmail.com",
                ServiceDate = "2026-09-10",
                VehicleIsDetailed = false,
                VehicleIsTinted = true,
                TotalCostOfServices = 999.99m,
                Overhead = 130m,
                AmountChargedToCustomer = 1000m
            },
            new Customer
            {
                CustomerId = 10,
                CustomerName = "Henry Irving",
                PhoneNumber = "513-777-0123",
                Email = "HenryIrving@gmail.com",
                ServiceDate = "2027-10-05",
                VehicleIsDetailed = true,
                VehicleIsTinted = false,
                TotalCostOfServices = 1099.99m,
                Overhead = 140m,
                AmountChargedToCustomer = 1100m
            }
        };
        public static List<Customer> GetTestCustomers()
        {
            Debug.WriteLine("GetTestCustomers()");
            return Customers;
        }
    }
}
