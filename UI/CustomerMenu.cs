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
            Console.WriteLine("Here are your options, what would you like to do?");
            Console.WriteLine("Press (1) to add a Customer.");
            Console.WriteLine("Press (2) in order to search for a customer");
            Console.WriteLine("Press (4) to go back/Exit");
        }

        MenuType IMenu.YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "1":
                    return MenuType.AddCustomerMenu;
                case "2":
                    return MenuType.MainMenu;
                case "4": 
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not considered a valid input.");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.WriteLine();
                    return MenuType.CustomerMenu;  
            }
        }
    }
}
