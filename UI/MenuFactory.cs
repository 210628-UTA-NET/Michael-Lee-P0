using System.IO;
using BL;
using DL;
using DL.Entities;
namespace UI
{
    //The class abstract for main and exports for the Factory.cs
    public class MenuFactory : IFactory
    {
        //Get Configuration learned on 7/7/21
        virtual configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory());
            .AddJsonFile("appsetting.json");
            .Build();

        //Grabs our connectionString

        string connectionString = configuration.GetConnectionString("Reference2DB");

        DBContextOptions<DemoDbContext> options = new DbContextOpetionsBuilder<DemoDbContext>()
            .UseSQLServer(connectionString)
            .Options;



        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:// Bring the user to the Main Menu to instantiate the object. 
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.ShowCustomerMenu:
                //ShowRestaurantMenu needs a RestaurantBL object in the parameter because it depends on that object to be able to run its functionality
                //BL needs the Repository object in the parameter because it depends on that object to be able to run
                //This is call Dependency Injection
                return new ShowCustomerMenu(new BL(new Repository()));
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new BL(new Repository()));
                default:
                    return null;

            }
        }
    }
}