using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Products
    {
        private string _name;
        private decimal _price;
        private string Description { get; set; }
        public int Product_Id { get; set; }
        public string Product_Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) //Does the string match letters A to Z. 
                {
                    throw new Exception("Sorry, you cannot include numbers.");
                }
                _name = value;
            }
        }
        public decimal Product_Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The Price cannot be less than zero.");
                }
                _price = value;
            }
        }
        public Products(){} //No arguements Constructor, no semicolon. 
        public Products(int p_Product_Id, string p_name, decimal p_Price, string p_Description) //purpose of parameters is to insert into the field. 
        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
        {
            Product_Id = p_Product_Id;
            Product_Name = p_name; 
            Product_Price = p_Price; 
            Description = p_Description;
        } 
         public override string ToString() //Add a two String method: another way for this class to create an object (create information to put in my database.)
        {
            return $"Product ID: {Product_Id}\n Name: {Product_Name}\n Price {Product_Price}\n Description {Description}";
        }
        
    }
}
