using BL;
using System;
using Models;
using System.Linq;
using System.Collections.Generic; 
namespace UI
{
    public class SearchCustomer : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Hello and Welcome to the Search Menu!");
            Console.WriteLine("How may I be of Assistance?");
            Console.WriteLine("[1] Press this button to search for a Customer.");
            Console.WriteLine("[2] Return to the Customer Menu.");
            Console.WriteLine("[0] Return to the Main Menu.");
            Console.WriteLine("===============================");
        } 
         MenuType IMenu.YourChoice()
        {
            string yourChoice = Console.ReadLine();
            switch (yourChoice)
            {
                case "1":
                    return MenuType.AddCustomerMenu;
                case "2":
                    return MenuType.SearchCustomer; //Put SearchforCustomer.menu when you get the chance. 
                case "0": 
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("The Information you wrote is not valid.");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.WriteLine();
                    return MenuType.SearchCustomer;  
            }
        }   
    }
}
