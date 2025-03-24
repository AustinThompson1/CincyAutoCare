using CareCare.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCare.Data.Logic
{
    public class TestCustomers
    {

        public static readonly List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                CustomerName = "John Doe",
                PhoneNumber = "513-777-7229",
                Email = "JohnDoe@gmail.com",
                ServiceDate = "2018-01-01",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "false",
                TotalCostOfServices = 199.99m,
                Overhead = 50m,
                AmountChargedToCustomer = 200m,
                //Tinting = new Tinting
                //{
                //    TintingType = null,
                //    TintPercent = null,
                //    CostOfWindowTint = null,
                //    TintAmount = null,
                //    HeadlightsAreTinted = "false",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = null
                //}
            },
            new Customer
            {
                Id = 2,
                CustomerName = "Jane Smith",
                PhoneNumber = "513-888-7229",
                Email = "JaneSmith@gmail.com",
                ServiceDate = "2019-02-15",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "true",
                TotalCostOfServices = 299.99m,
                Overhead = 60m,
                AmountChargedToCustomer = 300m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Dyed film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 150m
                //}
            },
            new Customer
            {
                Id = 3,
                CustomerName = "Alice Johnson",
                PhoneNumber = "513-999-7229",
                Email = "AliceJohnson@gmail.com",
                ServiceDate = "2020-03-20",
                VehicleIsDetailed = "false",
                VehicleIsTinted = "false",
                TotalCostOfServices = 399.99m,
                Overhead = 70m,
                AmountChargedToCustomer = 400m,
                //Tinting = new Tinting
                //{
                //    TintingType = null,
                //    TintPercent = null,
                //    CostOfWindowTint = null,
                //    TintAmount = null,
                //    HeadlightsAreTinted = "false",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = null
                //}
            },
            new Customer
            {
                Id = 4,
                CustomerName = "Bob Brown",
                PhoneNumber = "513-777-1234",
                Email = "BobBrown@gmail.com",
                ServiceDate = "2021-04-10",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "true",
                TotalCostOfServices = 499.99m,
                Overhead = 80m,
                AmountChargedToCustomer = 500m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Dyed film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 150m
                //}
            },
            new Customer
            {
                Id = 5,
                CustomerName = "Charlie Davis",
                PhoneNumber = "513-888-5678",
                Email = "CharlieDavis@gmail.com",
                ServiceDate = "2022-05-05",
                VehicleIsDetailed = "false",
                VehicleIsTinted = "true",
                TotalCostOfServices = 599.99m,
                Overhead = 90m,
                AmountChargedToCustomer = 600m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Dyed film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 150m
                //}
            },
            new Customer
            {
                Id = 6,
                CustomerName = "Diana Evans",
                PhoneNumber = "513-999-6789",
                Email = "DianaEvans@gmail.com",
                ServiceDate = "2023-06-25",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "true",
                TotalCostOfServices = 699.99m,
                Overhead = 100m,
                AmountChargedToCustomer = 700m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Metalized film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 150
                //}
            },
            new Customer
            {
                Id = 7,
                CustomerName = "Eve Foster",
                PhoneNumber = "513-777-7890",
                Email = "EveFoster@gmail.com",
                ServiceDate = "2024-07-30",
                VehicleIsDetailed = "false",
                VehicleIsTinted = "true",
                TotalCostOfServices = 799.99m,
                Overhead = 110m,
                AmountChargedToCustomer = 800m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Carbon film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Half Roll",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 50m
                //}
            },
            new Customer
            {
                Id = 8,
                CustomerName = "Frank Green",
                PhoneNumber = "513-888-8901",
                Email = "FrankGreen@gmail.com",
                ServiceDate = "2025-08-15",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "false",
                TotalCostOfServices = 899.99m,
                Overhead = 120m,
                AmountChargedToCustomer = 900m,
                //Tinting = new Tinting
                //{
                //    TintingType = null,
                //    TintPercent = null,
                //    CostOfWindowTint = null,
                //    TintAmount = null,
                //    HeadlightsAreTinted = "false",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = null
                //}
            },
            new Customer
            {
                Id = 9,
                CustomerName = "Grace Harris",
                PhoneNumber = "513-999-9012",
                Email = "GraceHarris@gmail.com",
                ServiceDate = "2026-09-10",
                VehicleIsDetailed = "false",
                VehicleIsTinted = "true",
                TotalCostOfServices = 999.99m,
                Overhead = 130m,
                AmountChargedToCustomer = 1000m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Ceramic film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 50m
                //}
            },
            new Customer
            {
                Id = 10,
                CustomerName = "Henry Irving",
                PhoneNumber = "513-777-0123",
                Email = "HenryIrving@gmail.com",
                ServiceDate = "2027-10-05",
                VehicleIsDetailed = "true",
                VehicleIsTinted = "true",
                TotalCostOfServices = 1099.99m,
                Overhead = 140m,
                AmountChargedToCustomer = 1100m,
                //Tinting = new Tinting
                //{
                //    TintingType = "Dyed film",
                //    TintPercent = 35,
                //    CostOfWindowTint = 100m,
                //    TintAmount = "Full",
                //    HeadlightsAreTinted = "true",
                //    TaillightsAreTinted = "false",
                //    CostOfLightsTint = 150m
                //}
            }
        };
        public static List<Customer> GetTestCustomers()
        {
            Debug.WriteLine("GetTestCustomers()");
            foreach (var customer in Customers)
            {
                Debug.WriteLine($"Customer: {customer.CustomerName}");
            }
            return Customers;
        }
    }
}
