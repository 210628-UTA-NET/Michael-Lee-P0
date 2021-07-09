using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class LineItem
    {
    private int _quantity;
        public Product Product {get; set;}
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Quantity needs to be greater than zero.");
                }
                _quantity = value;
            }
        }
    } 
}