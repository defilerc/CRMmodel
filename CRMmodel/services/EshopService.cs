using CRMmodel.CRMDBContext;
using CRMmodel.models;
using CRMmodel.options;
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

             CustomerOption customerOption = new CustomerOption { FirstName="Filomena", LastName="Panou", 
                 Address="Athina", Dob=new DateTime(2000,1,23), Email="pan@gmail.com",  };

             IBusinessLogic cs = new CustomerService();
            //Customer customer = cs.CreateCustomer(customerOption);

            List<Customer> customers = cs.FindAll(0, 5);

            customers.ForEach(c => Console.WriteLine(c.CustomerName));

            cs.UpdateCustomer(customerOption, 1);
            Console.WriteLine("----------------");


             customers = cs.FindAll(0, 5);

            customers.ForEach(c => Console.WriteLine(c.CustomerName));

        }

    }
}
