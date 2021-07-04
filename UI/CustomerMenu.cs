using System;
using System.Collections.Generic;
using DL;
using Models;

namespace UI
{
    //Creating an enum to make a connection
    class CustomerMenu : IMenu 
    {
        public void Menu()
        {
            Console.WriteLine("====== The Customer Menu======");
            Console.WriteLine("==========Welcome==========");
            Console.WriteLine("Press (1) to add a customer.");
            Console.WriteLine("Press (2) in order to search for a customer");
            Console.WriteLine("Press (3) to go back/Exit");
        }

        MenuType IMenu.YourChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    return MenuType.AddCustomerMenu;
                case "2":
                    return MenuType.MainMenu;
                case "3": 
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not considered a valid input.");
                    return MenuType.CustomerMenu;  
            }
        }
    }
}
