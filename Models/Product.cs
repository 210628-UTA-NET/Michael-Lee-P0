using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Product
    {
        private string _name;
        private double _price;
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
                    throw new Exception("Letters must be A to Z.");
                }
                _name = value;
            }
        }
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The Price cannot be zero.");
                }
                _price = value;
            }
        }
        
    }
}
