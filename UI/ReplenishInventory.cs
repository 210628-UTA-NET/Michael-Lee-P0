using System;
using System.Collections.Generic;
using Models;
using BL;

 namespace UI
 {
     public class ReplenishInventory : IMenu
     {
         public void Menu()
         {
             Console.WriteLine("====== Replenish Inventory ======");
             Console.WriteLine("[1] Choose which store of your preference.");
            Console.WriteLine("[2] Click 2 To Browse the Store.");
             Console.WriteLine("[0] Return to the Main Menu.");
         }

        public MenuType YourChoice()
        {
             throw new NotImplementedException();
        }

        // public MenuType YourChoice()
        // {
        //     string YourChoice = Console.ReadLine();
        //     switch (YourChoice)
        //     {
        //         case "1":
        //             return MenuType.StoreFrontMenu;
        //         case "2":
        //             return MenuType.StoreInventoryMenu;
        //         case "3":
        //             return MenuType.MainMenu;
        //     }
        // }
     }
}
    
    
//     Console.WriteLine("Change the quantity of the selected Product.");
// }//Continue to work on your project. 