using BL;
using DL;

namespace UI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu();
                    return new CustomerMenu();
                case MenuType.ShowCustomerMenu:
                //ShowRestaurantMenu needs a RestaurantBL object in the parameter because it depends on that object to be able to run its functionality
                //RestaurantBL needs the Repository object in the parameter because it depends on that object to be able to run
                //This is call Dependency Injection
                return new ShowRestaurantMenu(new RestaurantBL(new Repository()));
                case MenuType.AddRestaurantMenu:
                    return new AddRestaurantMenu(new RestaurantBL(new Repository()));
                default:
                    return null;

            }
        }
    }
}