using System;
using BL;
using System.Collections.Generic;

namespace UI
{
    public class StoreFrontInventoryMenu : IMenu
    {
        public void Menu() //My Current Options for the StoreFrontInventoryMenu. 
        {
            Console.WriteLine("Hello and Welcome to the StoreFront Inventory Menu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] View the Inventory.");
            Console.WriteLine("[2] Replenish Inventory.");
            Console.WriteLine("[0] Return");
        }
        public MenuType YourChoice()
        {
            throw new NotImplementedException(); //New NotImplementationException
        }
    }
}