using System;
using System.Collections.Generic;
namespace Models
{
    public class Customer
    { 
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}
        public string [] ListofOrders { get; set;}

        public Customer(string firstName, string lastName)

        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class" 
        {
            FirstName = firstName;
            LastName = lastName;
        } 
         public override string ToString() 
        {
            return FirstName + " " + LastName;
        }
    }
}