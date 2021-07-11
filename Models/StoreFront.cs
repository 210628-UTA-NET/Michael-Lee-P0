using System;

namespace Models
{
    public class StoreFront
    {
        /// <summary>
        /// create the properties towards the StoreFront class, using a private Access Modifier
        /// The class requires Name, Address, Inventory, and List of Orders.
        /// </summary> 
        public int Store_Id{get; set;}
        public string StoreName {get; set;}
        public string Address {get; set;}
        public string Inventory {get; set;}
        public string ListofOrder {get; set;}
    }
}