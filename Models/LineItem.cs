using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class LineItem
    {
    private int _quantity;

    private int LineItem_Id; 
        public string Product {get; set;}
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
        public LineItem(){} //No arguements Constructor, no semicolon. 
        public LineItem(int p_LineItem_Id, string p_product, int p_quantity)
        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
        {
            LineItem_Id = p_LineItem_Id;
            Product = p_product; 
            Quantity = p_quantity; 
        } 
         public override string ToString() //Add a two String method: another way for this class to create an object (create information to put in my database.)
        {
            return $"LineItem ID: {LineItem_Id}\n Product: {Product}\n Quantity: {Quantity}";
        }
    }
} 