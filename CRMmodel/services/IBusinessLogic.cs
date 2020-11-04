using CRMmodel.models;
using CRMmodel.options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.services
{
    public interface IBusinessLogic
    {
        Customer CreateCustomer(CustomerOption customerOption);
        Customer UpdateCustomer(CustomerOption customerOption, int customerId);

        List<Customer> FindCustomerInCity(String city);
        List<Customer> FindAll(int offset, int pageSize);

        Boolean delete(int customerId);
    }
}
