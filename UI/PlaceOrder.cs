using System; //Always add the using System. 
using System.Linq; //Language Integrated Query (uniform query syntax) to retrieve data from diff. sources and formats.   
using System.Collections.Generic;
using BL; //Using information from BL
using Models;

namespace UI
{
    public class PlaceOrder : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("==== Here, You can Place your Order ====");
            Console.WriteLine("[2] Start Placing your Order.");
            Console.WriteLine("[0] Return to the Main Menu.");
        }
        
        public MenuType YourChoice()
        {
            // MenuType  = MenuType.PlaceOrder;
            string YourChoice = Console.ReadLine(); //Creating the ReadLine and user Input
            switch (YourChoice)
            {
                case "2":
                    return MenuType.OrderMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("There is an Invalid Input.");
                    return MenuType.AddCustomerMenu;
            } 

        }
    }    
}