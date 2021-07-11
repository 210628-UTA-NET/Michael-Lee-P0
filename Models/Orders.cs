using System;
using System.Collections.Generic; //anything related to a list, dictionary
using System.Linq;

namespace Models //name of the model
{
    public class Orders
    {
         //Private string for _location, _totalPricePrice
        private string _location;
        private decimal _totalPrice;

        public int Order_Id {get;}
        public List<LineItem> OrderLineItems{get; set;}
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
                
        }
        public decimal Total_Price 
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }    
        } //Eventually, I will build an object (and a constructor). Do not need a semicolon. 
        public Orders(int id, string orderlocation, decimal price)
        {
            Order_Id = id;
            Location = orderlocation;
            Total_Price = price;

        }
        public Orders(){} //No Argument Constructor that will create an object with all my fields as NUll. 
        //Add a two String method: another way for this class to create an object (create information to put in my database.) 
        public override string ToString()
        {
            return $"Order_Id: {Order_Id}, Location: {_location}, Total_Price: {_totalPrice}";
        }

    }
}