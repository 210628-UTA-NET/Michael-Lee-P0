using System; //Always add the using System. 
using System.Linq; //Language Integrated Query (uniform query syntax) to retrieve data from diff. sources and formats.   
using System.Collections.Generic;
using BL; //Using information from BL
using Models;
namespace UI
{
    class Program
    { 
        static void Main(string[] args)
        {
            IMenu CustomerMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;
            while(loop)
            
            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

            }



        }
    }
}
