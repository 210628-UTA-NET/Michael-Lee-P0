using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void Menu();
        {
            Console.WriteLine("Hello, and Welcome to the Main Menu!");
            Console.WriteLine("How may I help you?");
            Console.WriteLine("[2] Add a Customer]");
            Console.WriteLine("[1] Display the Customers]");
            Console.WriteLine("[0] Exit]");
        }

        public MenuType YourChoice()
        {
            //Console.ReadLine() method will record what you type in the terminal. 
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "2": 
                    Console.WriteLine("Redirecting to Order Menu");
                    return MenuType.OrderMenu;
                case "1":
                    return MenuType.MainMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("This is an invalid input.");" 
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}