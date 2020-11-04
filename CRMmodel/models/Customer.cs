using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CRMmodel.models
{
    public class Customer
    {
        //Properties
        //primary key
        public int Id { get; set; }

        //attributes
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public float Balance { get; set; }
        public string VatNumber { get; set; }
        public string Phone { get; set; }
        public decimal TotalGross { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime Dob { get; set; }
        public DateTime RegistrationDate { get; set; }

        //foreign keys
        public List<Order> Orders { get; set; }

    }
}
