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

        public Customer(){}
        public int Customer_Id {get; set;}
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string Address {get; set;}
        public string Email {get; set;}
        public List<Orders> ListofOrders {get; set;}

        public Customer(int p_Customer_Id, string p_firstName, string p_lastName, string p_Address, string p_Email, List<Orders> p_ListOfOrder)

        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
        {
            Customer_Id = p_Customer_Id;
            FirstName = p_firstName;
            LastName = p_lastName;
            Address = p_Address;
            Email = p_Email;
            ListofOrders = p_ListOfOrder;
        } 
         public override string ToString() 
        {
            //return FirstName + " " + LastName;
            return $"Customer ID: {Customer_Id}\n FirstName: {_firstName}\n LastName: {_lastName}\n Address: {address}\nEmail: {email}\nListofOrders: {ListofOrders}";
        }
    }
}



