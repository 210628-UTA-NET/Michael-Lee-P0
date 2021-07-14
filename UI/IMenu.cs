
namespace UI //The Namespace of the UI. 
{
    public enum MenuType //Instead of strings, I used an enum to make connections for related named constants. 
    {
        MainMenu,
        CustomerMenu,
        MenuFactory,
        OrderMenu,
        AddCustomerMenu,
        SearchCustomer,
        StoreMenu,
        StoreFrontMenu,
        ShowCustomerMenu,
        StoreInventoryMenu,
        PlaceOrder,
        ViewOrderHistory,
        ReplenishInventory,
        Exit

    }
    public interface IMenu //It is important to create an interface for the IMenu. 
    {
        /// <summary>
        /// The CurrentMenu will describe the current Menu.  
        /// Will display the overall menu of the class and the choices you can make in that menu class 
        /// </summary>
        public void Menu();
        /// <summary>
        /// If I want to ChooseMenu, then the user will traverse menus that are based on the input. 
        /// This method will record the user's choice and change your many based on their input.
        /// </summary>
        /// <returns>Returnes a value that will dictate what menu to change to</returns>
        public MenuType YourChoice();
    }
}
    
