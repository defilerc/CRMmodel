using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.models
{
    public class Order
    {
        //primary key
        public int Id { get; set; }

        //attributes
        public DateTime Date { get; set; }

        //foreign keys or relations
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public List<OrderProduct> Orderproducts { get; set; }

    }
}
