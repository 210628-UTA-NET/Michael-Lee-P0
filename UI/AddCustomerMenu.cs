using System;
using Models;
using BL;
using System.Linq;
using System.Collections.Generic; 
namespace UI
{
    public class AddCustomerMenu : IMenu //Using the IMenu Reference. 
    {
        private static Customer _newCust = new Customer();  //Created a field called _newCust
        private CustomerBL _custBL;
        public AddCustomerMenu(CustomerBL p_custBL)
        {
            _custBL = p_custBL;
        } 
        public void Menu()
        {
            Console.WriteLine("Here is where you can add a Customer!");
            Console.WriteLine(@"  ______                  ");
            Console.WriteLine(@" |      |       |        |");
            Console.WriteLine(@" |      |       |        |");
            Console.WriteLine(@" |______|       |        |");
            Console.WriteLine(@" |      |       |        |");
            Console.WriteLine(@" |      |  _____|  ______|");
            Console.WriteLine(@" |      | |     |  |     |");
            Console.WriteLine(@" |      | |     |  |     |");
            Console.WriteLine(@" |      $ |_____$  |_____$");
            Console.WriteLine();
            Console.WriteLine($"[1] FirstName: "+_newCust.FirstName);
            Console.WriteLine("[2] LastName: "+_newCust.LastName);
            Console.WriteLine("[3] Address: "+_newCust.Address);
            Console.WriteLine("[4] Email: "+_newCust.Email);
            Console.WriteLine("[5] Add the Customer.");
            Console.WriteLine("[6] Return to the MainMenu.");
        }

        public MenuType YourChoice() //Need an access modifier for YourChoice. 
        {
            string yourChoice = Console.ReadLine();
            switch (yourChoice)
            {
                case "1":
                    Console.WriteLine("FirstName:");
                    _newCust.FirstName = Console.ReadLine();
                    return MenuType.AddCustomerMenu; 
                case "2":
                    Console.WriteLine("LastName:");
                    _newCust.LastName = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "3":
                    Console.WriteLine("Address:");
                    _newCust.Address = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "4":
                    Console.WriteLine("Email:");
                    _newCust.Email = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "5":
                    _custBL.AddCustomer(_newCust);
                    return MenuType.CustomerMenu;
                case "6":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("I am sorry, but the Information you put is Invalid.");
                    Console.WriteLine();
                    Console.ReadLine();
                    return MenuType.AddCustomerMenu;
            }
            //throw new NotImplementedException();
        }
    }
}