using System;
namespace UI
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Hello, and Welcome to the Main Menu!");
            Console.WriteLine("How may I help you?");
            Console.WriteLine("[0] Add a Customer]");
            Console.WriteLine("[1] Display the Customers]");
            Console.WriteLine("[2] Exit]");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0": 
                    System.Console.WriteLine("Redirecting to Order Menu");
                    return MenuType.OrderMenu;
                case "1":
                    return MenuType.MainMenu;
                case "2":
                    return MenuType.Exit;
                default:
                    System.Console.WriteLine("This is an invalid input.  Press Enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}