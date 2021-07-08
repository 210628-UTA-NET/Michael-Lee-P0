using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;
using System.Linq;

namespace DL
{
    public class Repository : IRepository
    {
        private const string _filePath = "./../DL/Database/Models.json";
        private string _jsonString;
        private DBModel model {get; set;} //When creating a property, a semicolon is not necessary. 
        public List<Customer> GetCustomers()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                throw new Exception($"File path is invalid" + Environment.CurrentDirectory); //
            }
                
            //This will return a list of restaurant from the jsonString that came from 
            model = JsonSerializer.Deserialize<DBModel>(_jsonString);
            model.Customers.ForEach(customer => {
	        Console.WriteLine(customer.FirstName + " " + customer.LastName);
            });

            return model.Customers;
        }
    }
    
        
}