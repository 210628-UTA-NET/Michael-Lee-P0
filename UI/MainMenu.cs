using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Hello, and Welcome to the Main Menu!");
            Console.WriteLine("How may I help you?");
            Console.WriteLine("[0] Add a Customer Profile");
            Console.WriteLine("[1] Display the Customers");
            Console.WriteLine("[2] Exit");
        }

        public MenuType YourChoice()//Allow MenuType to have YourChoice()
        {
            //Console.ReadLine() method will record what you type in the terminal. 
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0": 
                    Console.WriteLine("Redirecting to Order Menu");
                    return MenuType.OrderMenu;
                case "1":
                    return MenuType.MainMenu;
                case "2":
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