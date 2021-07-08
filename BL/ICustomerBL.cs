using System;
using System.Collections.Generic;
using Models;

namespace BL
{
    ///<summary>
    ///Handles all the business logic for store model
    ///In charger of processing, cleaning, and validation of data
    ///</summary>
    public interface ICustomerBL
    {
        List<Customer> GetCustomers();

        Customer AddCustomer(Customer p_customer);
    }
}
