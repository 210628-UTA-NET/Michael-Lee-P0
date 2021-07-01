using System;
using System.Collections.Generic;
using Models;

namespace ICustomerBL
{
    ///<summary>
    ///Handles all the business logic for store model
    ///In charger of processing, cleaning, and validation of data
    ///</summary>
    public interface ICustomerBL
    {
        List<Customer> GetCustomers();
    }
}