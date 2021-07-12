using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BL;
using DL;
using DL.Entities;

namespace UI
{
    public class ViewOrderHistory : IMenu
    {
        public MenuType GetSelection()
        {
            throw new System.NotImplementedException();
        }

        public void Menu()
        {
            Console.WriteLine("Hello, you can View your Order History!");
            Console.WriteLine("How may I help you? (Press the number keys corresponded)");
            Console.WriteLine("[1] View your Order History.");
            Console.WriteLine("[2] Return to the StoreFront Menu."); //This results to the order being completed. 
            Console.WriteLine("[3] Return to MainMenu.");
        }
        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine(); //Creating the ReadLine and user Input
            switch (userInput)
            {
                 case "1":
                     return MenuType.ViewOrderHistory;//Creating a new return method: ViewOrders.

                case "2":
                    return MenuType.StoreFrontMenu; //Return to the StoreFrontMenu. 
                case "3":
                    return MenuType.MainMenu; //Return to the MainMenu. 
                default:
                    System.Console.WriteLine("This is an Invalid Input, Please press Enter if you want to continue.");
                    Console.ReadLine();
                    return MenuType.OrderMenu;
            }
        }
        // public string ViewOrders() //Building the ViewOrders Return Method. 
        // {
        //     return new Customer(new StoreFront(new Order(new DemoDBContext(options)))); 
        // }
    }
}


