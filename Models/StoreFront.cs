using System;

namespace Models
{
    public class StoreFront
    {
        /// <summary>
        /// create the properties towards the StoreFront class, using a private Access Modifier
        /// The class requires Name, Address, Inventory, and List of Orders.
        /// For the sake of my fields and classes, I am making the access modifiers Private. 
        /// </summary> 
        private int Store_Id{get; set;}
        private string StoreName {get; set;}
        private string Address {get; set;}
        private string Inventory {get; set;}
        private string ListofOrder_Id {get; set;}
        public StoreFront(){} //No arguements Constructor, no semicolon. 
        public StoreFront(int p_Store_Id, string p_StoreName, string p_Address, string p_Inventory, string p_ListofOrder_Id) //purpose of parameters is to insert into the field. 
        //You can override the default string functions, allowing to output the object parameters or receive and namespace.class COnstructor" 
        {
            Store_Id = p_Store_Id;
            StoreName = p_StoreName; 
            Address = p_Address; 
            Inventory = p_Inventory;
            ListofOrder_Id = p_ListofOrder_Id;
        } 
         public override string ToString() //Add a two String method: another way for this class to create an object (create information to put in my database.)
        {
            return $"Store ID: {Store_Id}\n StoreName: {StoreName}\n Address {Address}\n Inventory {Inventory}\n ListofOrder Id {ListofOrder_Id}";
        }
    }
}