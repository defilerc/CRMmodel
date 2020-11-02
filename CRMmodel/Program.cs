using CRMmodel.models;
using CRMmodel.services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CRMmodel
{
    public class Program
    {
        static void Main(string[] args)
        {
            EshopService eshop = new EshopService();
            eshop.MainProcess();
        }


       

    }
}
