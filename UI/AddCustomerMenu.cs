using System;
using Models;
using BL;
using System.Collections.Generic; 
namespace UI
{
    public class AddCustomerMenu : IMenu
    {
        //Creating static instance for the Customer Object. 
        private static Models.Customer _newCustomer = new Models.Customer();
        //Create an _ICustomerBL interface Type
        private ICustomerBL _customerBL;
        //The AddCustomerMenu is called by MenuFactory
        public AddCustomerMenu(ICustomerBL p_store)
        {
            _customerBL = p_store;
        }   
        public void Menu()
        {
            Console.WriteLine("[1] FirstName" + _newCustomer.FirstName);
            Console.WriteLine("[2] LastName" + _newCustomer.LastName);
            Console.WriteLine("[3] Address" + _newCustomer.Address);
            Console.WriteLine("[4] Email" + _newCustomer.Email);
            Console.WriteLine("[5] Add Customer");
            Console.WriteLine("[0] Go Back");
        }
        public MenuType YourChoice()
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.WriteLine("Customer's FirstName:");
                    //changes _newCustomer Name object parameter.
                    _newCustomer.FirstName = Console.ReadLine();
                    //returns Menutype to the main, dictating to remain within the addCustomer menu
                    return MenuType.AddCustomerMenu;
                case "2":
                    Console.WriteLine("Customer's LastName:");
                    // _newCustomer LastName object parameter.
                    _newCustomer.LastName = Console.ReadLine();
                    //returns menu type to the main, dictating to remain within the addCustomer menu
                    return MenuType.AddCustomerMenu;
                case "3":
                    Console.WriteLine("Customer's Address:");
                    // _newCustomer Address object parameter. 
                    _newCustomer.Address = Console.ReadLine();
                    return MenuType.CustomerMenu;
                case "4":
                    Console.WriteLine("Customer's Email:");
                    //Have a _new Customer Email object parameter for the user input. 
                    _newCustomer.Email = Console.ReadLine();
                    //Return the MenuType to the main addCustomer menu. 
                    return MenuType.CustomerMenu;
                case "5":
                    //Create the _newCustomer towards the _customerBL
                    _customerBL.AddCustomer(_newCustomer);
                    //Create a template for a new customer. 
                    _newCustomer.FirstName = "";
                    _newCustomer.LastName = "";
                    _newCustomer.Address = "";
                    _newCustomer.Email = "";
                    //Return the MenuType of main, returning an Add/Retrieve Customer Menu. 
                    return MenuType.CustomerMenu;
                case "0": 
                    Console.WriteLine("Redirecting to Order Menu");
                    return MenuType.CustomerMenu;
                
                default:
                    Console.WriteLine("Unfortunately, the Input is not correct.");
                    Console.WriteLine("If you want to continue, press Enter.");
                    Console.ReadLine();
                    //It is important to return to the menu type, remaining to the addCustomer menu
                    return MenuType.AddCustomerMenu;
            }        
        }

    }
}