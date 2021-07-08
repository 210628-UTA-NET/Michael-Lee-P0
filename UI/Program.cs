using System; //Always add the using System. 
using System.Linq; //Language Integrated Query (uniform query syntax) to retrieve data from diff. sources and formats.   
using System.Collections.Generic;
using BL; //Using information from BL
using Models;
namespace UI //Namspace is currently UI
{
    class Program
    { 
        static void Main(string[] args) //Main 
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu; //CurrentMenu will equal the MenuTyep.MainMenu. 
            IFactory menuFactory = new MenuFactory();
            
            
            while (repeat)
            {
                Console.Clear();
                //The Call Menu will Display
                restMenu.Menu();
                //Use the CurrentMenu to impy the user's choice
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        restMenu = menuFactory.GetMenu(MenuType.MainMenu);
                        break;
                    case MenuType.CustomerMenu:
                    //Call the Factory GetMenu(), Returning CustomerMenu()
                        restMenu = menuFactory.GetMenu(MenuType.CustomerMenu);
                        break;
                    case MenuType.ShowCustomerMenu:
                        restMenu = menuFactory.GetMenu(MenuType.ShowCustomerMenu);
                        break;
                    case MenuType.OrderMenu:
                        restMenu = menuFactory.GetMenu(MenuType.OrderMenu);
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
        }
    }
}
