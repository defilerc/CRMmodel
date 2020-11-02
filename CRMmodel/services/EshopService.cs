using CRMmodel.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.services
{
    public class EshopService
    {
        public void MainProcess()
        {
            Console.WriteLine("CRM Application!");

            var product = Product.createProduct();
            var customer = Customer.createCustomer();

            var Order = new Order
            {
                Customer = customer,
                Products = new List<Product> { product },
                Date = DateTime.Now
            };

            Console.WriteLine(product);
            Console.WriteLine(customer);
            product.IncreasePriceIfBelowLimit(35);
            Console.WriteLine(product);

        }

    }
}
