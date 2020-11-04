﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //foreign keys
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
