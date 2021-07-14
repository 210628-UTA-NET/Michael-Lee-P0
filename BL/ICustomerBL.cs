using System;
using System.Collections.Generic;
using Models;

namespace BL
{
    ///<summary>
    ///Handles all the business logic for ICustomer
    ///In charger of processing, cleaning, and validation of data
    ///</summary>
    public interface ICustomerBL 
    {
        //To gather the customers from the database, there needs to be a return list.
        List<Customer> GetCustomers();
        Customer GetCustomers(Customer p_customer);
        bool AddCustomer(Customer p_customer);
        // AddCustomer(Customer p_customer);
        //Added SearchCustomer
        Customer SearchCustomer(string enterCust);
    }
}
