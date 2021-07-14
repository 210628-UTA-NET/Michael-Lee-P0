using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using BL;
using DL;
using DL.Entities;
using System;

namespace UI
{
    //The class abstract for main and exports for the Factory.cs
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            //Get Configuration from the appsetting.json earned on 7/7/21
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsetting.json")
                 .Build();

            //Grabs our connectionString

             string connectionString = configuration.GetConnectionString("Reference2DB");

             DbContextOptions<DemoDBContext> options = new DbContextOptionsBuilder<DemoDBContext>()
                 .UseSqlServer(connectionString)
                 .Options; 
            
            switch (p_menu)
            {
                case MenuType.MainMenu:// Bring the user to the Main Menu to instantiate the objects. 
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.OrderMenu:
                    return new OrderMenu();
                case MenuType.ShowCustomerMenu:
                     return new ShowCustomerMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                // case MenuType.StoreFrontMenu:
                //     return new StoreFrontMenu();
                case MenuType.AddCustomerMenu:
                     return new AddCustomerMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                // case MenuType.SearchCustomer:
                //     return new SearchCustomer(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                // case MenuType.StoreInventoryMenu();
                //     return new StoreInventoryMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                //ShowCustomerMenu needs a BL object in the parameter because it depends on that object to be able to run its functionality
                //BL needs the Repository object in the parameter because it depends on that object to be able to run
                //This is call Dependency Injection

                /* return new ShowCustomerMenu(new CustomerBL(new Repository(new FirstDatabaseContext()));
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new Repository()));*/
                default:
                    return null; 

            }
        }

        private void Build()
        {
            throw new NotImplementedException();
        }
    }
}