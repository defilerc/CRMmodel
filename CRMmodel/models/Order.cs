using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime Date { get; set; }


    }
}
