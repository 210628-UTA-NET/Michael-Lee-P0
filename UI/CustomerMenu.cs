using System;
using System.Collections.Generic;
using DL;
using Models;

namespace UI
{
    //Creating an enum to make a connection
    class CustomerMenu : IMenu 
    {
        public void showMenu()
        {
            Console.WriteLine("====== The Customer Menu======");
            Console.WriteLine("==========Welcome==========");
            Console.WriteLine("Press (1) to add a customer.");
            Console.WriteLine("Press (2) in order to search for a customer");
            Console.WriteLine("Press (3) to go back");
        }

        MenuType IMenu.YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}
