using System;
using System.Linq; 
using System.Collections.Generic;
using BL;
using Models;
namespace UI
{
    class Program
    { 
       
        static List<Customer> Customers { get; set;} 
        static void Main(string[] args)
        {
           Customers = new List<Customer>();
           CustomerBL cx = new CustomerBL(); //Constructor has parenthesis. 
           Customers = cx.GetCustomers(); //This is a Method
           //A Lamda Expression creates an anonymous function
           Customers.ForEach(customer => { 
           Console.WriteLine(customer.FirstName);
           Console.WriteLine(customer.LastName);
           Console.WriteLine(customer.Address);
           Console.WriteLine(customer.PhoneNumber);
           Console.WriteLine(customer.Email);
           });
           
        }
    }
}
