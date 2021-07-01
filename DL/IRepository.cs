using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; //Using Json 
using Models; //Connected to Models 

namespace DL //The namespace for DL
{
    ///<summary>
    /// It is responsible for accessing our database, transmitted towards the JSON file stored in our folder
    ///</summary>
    public interface IRepository
    {
        List<Customer> GetCustomers();

    }
        
        
}