using System;

namespace UI 
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Hello, and Welcome to the Main Menu!");
            Console.WriteLine("How may I help you?");
            Console.WriteLine("[0] Add new Customer");
            Console.WriteLine("[1] Go to the Order Menu.");
            Console.WriteLine("[2] Go to the Store Menu.");
            Console.WriteLine("[3] Go to the Store Inventory Menu.");
            Console.WriteLine("[4] Access the Customer Menu.");

            Console.WriteLine("[9] Exit");
        }

        public MenuType YourChoice()//Allow MenuType to have YourChoice()
        {
            //Console.ReadLine() method will record what you type in the terminal. 
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0": 
                    return MenuType.AddCustomerMenu;
                case "1":
                    return MenuType.OrderMenu;
                case "2":
                    return MenuType.StoreMenu;
                case "3":
                    return MenuType.StoreInventoryMenu; 
                case "4":
                    return MenuType.ShowCustomerMenu;
                case "9":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("This is an invalid input."); 
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    //The Input was not correct, returning to the main menu for further instructions. 
                    return MenuType.MainMenu;
            }
        }
    }
}