using System; //Always add the using System. 
using System.Linq; //Language Integrated Query (uniform query syntax) to retrieve data from diff. sources and formats.   
using System.Collections.Generic;
using BL; //Using information from BL
using Models;
namespace UI //Namspace is currently UI
{
    class Program
    { 
        public static void Main(string[] args) //Main 
        {
            IMenu restMenu = new MainMenu(); //
            bool repeat = true; //set a condition for the while statement.
            MenuType currentMenu = MenuType.MainMenu; //CurrentMenu will equal the CurrentMenu.MainMenu. 
            IFactory menuFactory = new MenuFactory(); //Have a class instance of the MenuFactory and a reference towards the interface type. 
            
            
            while (repeat)
            {
                Console.Clear();
                //The Call Menu will Display
                restMenu.Menu();
                //Use the CurrentMenu to impy the user's choice
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu: //Add a MenuType.MainMenu()
                        restMenu = menuFactory.GetMenu(MenuType.MainMenu);
                        break;
                    case MenuType.CustomerMenu: //Added a CustomerMenu()
                    //Call the Factory GetMenu(), Returning CustomerMenu()
                        restMenu = menuFactory.GetMenu(MenuType.CustomerMenu);
                        break;
                    case MenuType.ShowCustomerMenu: //Added a ShowCustomerMenu()
                        restMenu = menuFactory.GetMenu(MenuType.ShowCustomerMenu);
                        break;
                    case MenuType.OrderMenu: //Added an OrderMenu()
                        restMenu = menuFactory.GetMenu(MenuType.OrderMenu);
                        break;
                    case MenuType.AddCustomerMenu: //Added a AddCustomerMenu()
                        restMenu = menuFactory.GetMenu(MenuType.AddCustomerMenu);
                        break;
                    case MenuType.SearchCustomer: //Added a SearchCustomer()
                        restMenu = menuFactory.GetMenu(MenuType.SearchCustomer);
                        break;
                    case MenuType.StoreFrontMenu: //This is essentially a ViewStoreFrontInventoryMenu()
                        restMenu = menuFactory.GetMenu(MenuType.StoreFrontMenu);
                        break;
                    case MenuType.PlaceOrder: //Added a PlaceOrder()
                        restMenu = menuFactory.GetMenu(MenuType.PlaceOrder);
                        break;
                    case MenuType.ViewOrderHistory: //Added a ViewOrderHistory()
                        restMenu = menuFactory.GetMenu(MenuType.ViewOrderHistory);
                        break;
                    case MenuType.ReplenishInventory: //Added a ReplenishInventory()
                        restMenu = menuFactory.GetMenu(MenuType.ReplenishInventory);
                        break;
                    
                    case MenuType.Exit: //This is the ends condition of the switch statement
                        Console.WriteLine("Thank you for your time!");
                        Console.WriteLine("See you next Time!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("The Information cannot be processed.  Please try again.");
                        break;
                }
            }
            Console.Clear();//Created a Console.Clear method to clear the screen and console buffer. 
            Console.WriteLine("The Application is Closed.  Thank you for your time!");
        }
    }
}
