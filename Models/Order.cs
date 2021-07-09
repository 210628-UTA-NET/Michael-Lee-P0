using System;
using System.Collections.Generic; //anything related to a list, dictionary
using System.Linq;

namespace Models //name of the model
{
    public class Order
    {
        private string _price; //Private string for Price
        public int Id {get;}
        public List<LineItem> LineItems{get; set;}
        public Address Location {get; set;}
        public Double Price {get; set;}
        public Order(int id, Address orderlocation)
        {
            
        }
    }
}