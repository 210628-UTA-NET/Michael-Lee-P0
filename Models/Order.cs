using System;
using System.Collections.Generic; //anything related to a list, dictionary
using System.Linq;

namespace Models //name of the model
{
    public class Order
    {
        public int Id {get;}
        public List<LineItem> LineItems{get; set;}
        public Address Location {get; set;}
        public DateTime OrderDate {get; set;}
        public Order(int id, Address orderlocation)
        {
            
        }
    }
}