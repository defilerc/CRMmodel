using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace CRMmodel.models
{
    public class Product
    {

        //primary key
        public int Id { get; set; }

        //attributes
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InventoryQuantity { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        //foreign keys
        public List<OrderProduct> OrderPproducts { get; set; }


    }
}
