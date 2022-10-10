using System;
using System.Collections.Generic;

namespace Generics_Delegates_Exercise
{
    internal class CarManagement
    {
        public void Execute()
        {
            const int MENU_OPT_INVENTORY_CAR = 1;
            const int MENU_OPT_VIEW_CHECKOUT = 2;

            var allCarsInInventory = InventoryRepo.InventoryCars;
            var checkOutInstance = new Checkout();

            while (true)
            {
                Console.WriteLine($"Please Choose: {Environment.NewLine}");

                Console.WriteLine("1. See Car inventory");
                Console.WriteLine($"2. See checkout basket");
                Console.WriteLine($"-1. Go back{Environment.NewLine}");

                var menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection == MENU_OPT_INVENTORY_CAR)
                {
                    DisplayInventory(allCarsInInventory, checkOutInstance);
                }
                else if(menuSelection == MENU_OPT_VIEW_CHECKOUT)
                {
                    checkOutInstance.PrintOrders();
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }

        void DisplayInventory(Dictionary<int, Car> allCarsInInventory, Checkout checkOutInstance)
        {
            int quitValue = -1;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"This is the inventory: ");
                foreach (var carKV in allCarsInInventory)
                {
                    var carInstance = carKV.Value;

                    Console.WriteLine($"Inventory Id: {carKV.Key}");
                    var info = $"Car Brand: {carInstance.CarBrand}{Environment.NewLine}";
                    info += $"Car Year: {carInstance.Year:d}{Environment.NewLine}";
                    info += $"Car Color: {carInstance.CarColor}";

                    Console.WriteLine($"{info}"); Console.WriteLine();
                }

                Console.WriteLine("Please select Id or enter -1 to go back to previous menu");

                var inputId = int.Parse(Console.ReadLine()); //Assume that selection will not require error handling 

                if (inputId == quitValue) break;

                checkOutInstance.AddToCheckout(allCarsInInventory[inputId]);
                Console.WriteLine("Item has been added to checkout");
            }
        }
    }
}
