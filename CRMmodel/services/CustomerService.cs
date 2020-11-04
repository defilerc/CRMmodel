using CRMmodel.CRMDBContext;
using CRMmodel.models;
using CRMmodel.options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMmodel.services
{
    public class CustomerService : IBusinessLogic
    {
        public Customer CreateCustomer(CustomerOption customerOption)
        {
            if (!CustomerOptionValidation(customerOption))
                throw new Exception("Null customerOption given");

            Customer customer = new Customer
            {
                CustomerName = customerOption.FirstName + " "+ customerOption.LastName, 
                Address = customerOption.Address, 
                Balance = 0,
                Dob = customerOption.Dob
            };
            using AppDbContext appDb = new AppDbContext();
            appDb.Customers.Add(customer);
            appDb.SaveChanges();
            return customer;
        }


        public Boolean CustomerOptionValidation(CustomerOption customerOption)
        {
            //validations
            if (customerOption == null) return false;
            if (customerOption.LastName == null) return false;
            if (customerOption.Address == null || customerOption.Address.Equals("Lamia"))
                return false;

            return true;
        }


        public List<Customer> FindAll(int offset, int pageSize)
        {
            using AppDbContext appDb = new AppDbContext();
            List<Customer> customers = appDb
                .Customers
                .Select(p => p)
                .Skip(offset)
                .Take(pageSize)
                .ToList();
            return customers;
        }

        public List<Customer> FindCustomerInCity(string city)
        {
            int maxSize = 100;
             using AppDbContext appDb = new AppDbContext();
            List<Customer> customers = appDb
                .Customers
                .Where(p => p.Address!=null && p.Address.Equals(city))
                .Take(maxSize)
                .ToList();
            return customers;
        }

        public Customer UpdateCustomer(CustomerOption customerOption, int customerId)
        {
            using AppDbContext appDb = new AppDbContext();
            Customer customer = appDb.Customers.Find(customerId);
            if (customer == null) return null;
            customer.Address = customerOption.Address;
            customer.CustomerName = customerOption.FirstName + " " + customerOption.LastName;
            customer.Dob = customerOption.Dob;
            appDb.SaveChanges();
            return customer;
        }

        public Boolean delete(int customerId)
        {
            using AppDbContext appDb = new AppDbContext();
            appDb.Customers.Remove(appDb.Customers.Find(customerId));
            return true;
        }


    }
}
