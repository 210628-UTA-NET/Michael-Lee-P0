using System;
using System.Collections.Generic;
namespace Models
{
    public class Customer
    { 
        string FirstName { get; set;}
        string LastName { get; set;}


        public Customer(string firstName, string lastName)

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