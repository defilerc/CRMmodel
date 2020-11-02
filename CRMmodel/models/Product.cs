using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace CRMmodel.models
{
    public class Product
    {

        //private string name; // field
        //public string Name   // property
        //{
        //    get { return name; }   // get method
        //    set { name = value; }  // set method
        //}



        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InventoryQuantity { get; set; }


        public override string ToString()
        {
            return "Name: " + Name
        + " Price: " + Price
        + " InventoryQuantity: " + InventoryQuantity;
        }

        public void IncreasePriceIfBelowLimit(int limit)
        {
            if (InventoryQuantity < limit)
                Price += 1;
        }

        public static Product createProduct()
        {
            Console.WriteLine("Give the name of the product");
            string productName = Console.ReadLine();
            Console.WriteLine("Give the price of the product");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give the quantity of the product");
            int quantity = Int32.Parse(Console.ReadLine());


            var product = new Product
            {
                Name = productName,
                Price = price,
                InventoryQuantity = quantity
            };
            return product;
        }
    }
}
