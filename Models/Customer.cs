using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Models
{
    public class Customer
    { 
        private string _firstName; //Private string for firstName 
        private string _lastName; //Private string for lastName
        public Customer(){}
        public int Id { get; set;}
        public string FirstName
        { 
            get
            {
                return _firstName;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("FirstName only holds letters.");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("LastName only holds letters.");
                }
                _lastName = value;
            }
        }

        public string Address { get; set;}
        public string Email { get; set;}
        public List<Order> ListofOrders {get; set;}

        public Customer(string firstName, string lastName)

        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
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