using System; //Always put the using System. 
namespace UI //The Namespace of the UI. 
{
    public enum MenuType 
    {
        MainMenu,
        OrderMenu,
        CustomerMenu,
        AddCustomerView,
        Exit

    }
    public interface IMenu
    {
        /// <summary>
        /// Will display the overall menu of the class and the choices you can make in that menu class 
        /// </summary>
        void Menu();
        /// <summary>
        /// This method will record the user's choice and change your many based on their input
        /// </summary>
        /// <returns>Returnes a value that will dictate what menu to change to</returns>
        MenuType YourChoice();
    }
}
    }
}