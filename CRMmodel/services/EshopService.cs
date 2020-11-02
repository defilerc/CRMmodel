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
                var customer = Customer.createCustomer();

                var Order = new Order
            {
                Customer = customer,
                Products = new List<Product> {  },
                Date = DateTime.Now
            };

            for( int i=0;i<3;i++)
                  Order.Products.Add( Product.createProduct() );
           
            foreach( Product product in Order.Products)
            {
                Console.WriteLine(product);
            }


            //   Product product;

            //Console.WriteLine(product);
            //Console.WriteLine(customer);
            //product.IncreasePriceIfBelowLimit(35);
            //Console.WriteLine(product);

        }

    }
}
