using System;

namespace UI
{
    public class StoreFrontMenu : IMenu
    {
        /* public string _location {get; set;}
        public static StoreFrontMenu newMenu = new StoreFrontMenu();
        public void storeLocation(StoreFrontMenu p_storeFront)
        {
            newMenu._location = p_storeFront;
        } */

        public void Menu() 
        {
            Console.WriteLine("Welcome to StorFrontMenu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[3] View Order History");
            Console.WriteLine("[2] Manage Inventory");
            Console.WriteLine("[1] Find a Different StoreFront");
            Console.WriteLine("[0] Return");
        }
        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    //newMenu._location = "";
                    return MenuType.StoreFrontMenu;
                case "2":
                    return MenuType.StoreInventoryMenu;
                case "3":
                  //  return MenuType.StoreFrontOrderHistory
                case "4":
                    return MenuType.OrderMenu;
                default:
                    return MenuType.StoreFrontMenu;
            }
        }
    }
}