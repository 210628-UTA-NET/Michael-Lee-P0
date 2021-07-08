using System;

namespace UI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("[3] Enter the Store.");
            Console.WriteLine("[2] View the Current List.");
            Console.WriteLine("[1] Review the Current List.");
            Console.WriteLine("[0] Return to the Main Menu.");
        }
        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "3":
                    return MenuType.StoreFrontMenu;
                case "1":
                    return MenuType.StoreMenu;
                case "0":
                        return MenuType.MainMenu;
                    default:
                        return MenuType.StoreMenu;

            }

        }
    }

}