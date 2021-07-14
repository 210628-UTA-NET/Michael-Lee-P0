using System;
using BL;
using Models;
using System.Collections.Generic;

namespace UI
{
    public class ShowCustomerMenu : IMenu
    {
        private ICustomerBL _customerBL; //Created a Parameter for ICustomerBL. 
        public ShowCustomerMenu(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customers:");
            Console.WriteLine("-------------------");
            //instantiates a list of Customer of type ICustomerBL and calls the "GetAllCustomers" Method within the BL that retrieves information from the repository
            List <Customer> customers = _customerBL.GetCustomers();

            //loop through list of customers and print the Customer Object (capable via the toString override method)
            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("[0] Press 0 to go back");
            
        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();

            switch (YourChoice)
            {
                case "0":
                    //returns user to CustomerMenu based off of UserInput
                    return MenuType.CustomerMenu;
                default:
                    Console.WriteLine("I am sorry, but this is the wrong input.");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    //Default notifies of Improper input then returns user to CustomerMenu
                    return MenuType.CustomerMenu;
            }    
        }
    }
}