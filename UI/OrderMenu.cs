using System;
using System.Collections.Generic; 

namespace UI
{
    public class OrderMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Hello, Welcome the Order Menu!");
            Console.WriteLine("How can I assist you?");
            Console.WriteLine("[0] Add an order item of your preference.");
            Console.WriteLine("[1] Completed the order."); //This results to the order being completed. 
        }
        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine(); //Creating the ReadLine and user Input
            switch (userInput)
            {
                case "0";
                    return MenuType.OrderMenu;
                case "1";
                    return MenuType.MainMenu;
                default:
                    System.Console.WriteLine("This is an Invalid Input, Please press Enter if you want to continue.");
                    Console.ReadLine();
                    return MenuType.OrderMenu;
            } 
        }
    }
}
