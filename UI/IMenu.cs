using System;
namespace UI
{
    public enum MenuType {
        MainMenu,
        OrderMenu,
        CustomerMenu,
        AddCustomerView,
        CustomerView,
        Exit

    }
    public interface IMenu {
        void showMenu();
        MenuType YourChoice();
    }
}
    }
}