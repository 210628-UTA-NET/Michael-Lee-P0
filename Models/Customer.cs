using System;
using System.Collections.Generic; //This is for collections. 
using System.Text.RegularExpressions; //Need this system for Regex. 
namespace Models
{
    public class Customer
    { 
        private string _firstName; //Private string for firstName 
        private string _lastName; //Private string for lastName
        private string address; //Private string for address
        private string email; //Private string for email

        public Customer(){} //No Args Constructor to build an object without parameters. 
        public int Customer_Id { get; set;}
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
        public List<Orders> ListofOrders {get; set;}

        public Customer(string firstName, string lastName, string Address, string ListOfOrder)

        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
        } 
         public override string ToString() 
        {
            //return FirstName + " " + LastName;
            return $"Customer ID: {Customer_Id}\n FirstName: {_firstName}\n LastName: {_lastName}\n Address: {address}\nEmail: {email}\nListofOrders: {ListofOrders}";
        }
    }
}