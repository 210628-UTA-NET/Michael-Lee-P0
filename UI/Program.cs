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
            IMenu CustomerMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu; //CurrentMenu will equal the MenuTyep.MainMenu. 
            
            
            while (repeat)
            {
                Console.Clear();
                //The Call Menu will Display
                CustomerMenu.Menu();
                //Use the CurrentMenu to impy the user's choice
                currentMenu = CustomerMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        CustomerMenu = new MainMenu();
                        break;
                    
                    case MenuType.CustomerMenu:
                    //Call 
                        
                    
                    case MenuType.Exit: //This is the ends condition of the switch statement
                        Console.WriteLine("Thank you for your time!");
                        Console.WriteLine("See you next Time!");
                        repeat = false;
                    default:
                        Console.WriteLine("The Information cannot be processed.  Please try again.");
                        break;
                }
            }
        }
    }
}
