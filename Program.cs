using System;
using Models;
using System.Linq; 
using System.Collections.Generic;
namespace UI
{
    class Program
    { 
       
        static List<Customer> Customers { get; set;} 
        static void Main(string[] args)
        {
           Customers = new List<Customer>();
           string flag = "";
           do
           {
           Console.WriteLine("Enter First Name");
           string firstName = Console.ReadLine();

           Console.WriteLine("Enter Last Name");
           string lastName = Console.ReadLine();
            Customers.Add(new Customer(firstName, lastName));   
            Console.WriteLine("Enter 'Y' To Continue Add New Customers");
            flag = Console.ReadLine(); 
           } while (flag == "Y");
           
            Customers.ForEach(customer => 
            {
                Console.WriteLine(customer.ToString());
            });
        }
    }
}
