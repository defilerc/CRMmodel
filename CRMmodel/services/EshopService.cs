using CRMmodel.CRMDBContext;
using CRMmodel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMmodel.services
{
    public class EshopService
    {
        public void MainProcess()
        {
            //create or insert
            Customer customer = new Customer {  CustomerName="Panagiotis", Address="Athina", Balance=100, 
                Dob=new DateTime(1999,8,1)};
            Console.WriteLine(customer.Id);
            using AppDbContext appDb = new AppDbContext();
            appDb.Customers.Add(customer);
            appDb.SaveChanges();
            Console.WriteLine(customer.Id);

            //read or select
            Customer customer1 = appDb.Customers.Find(1);
            Console.WriteLine(customer1.CustomerName);

            Customer customer2 = appDb.Customers.Where(p => p.CustomerName.Equals("Sofia")).FirstOrDefault();
            List<Customer> customers = appDb.Customers.Where(p => p.CustomerName.Equals("Sofia")).ToList();
        }

    }
}
