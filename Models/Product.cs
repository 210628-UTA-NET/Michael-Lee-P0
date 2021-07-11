using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private string Description { get; set; }
        public string Name 
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
        public decimal Price 
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
        
    }
}
