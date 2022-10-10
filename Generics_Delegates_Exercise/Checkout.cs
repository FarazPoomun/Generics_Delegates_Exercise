using System;
using System.Collections.Generic;

namespace Generics_Delegates_Exercise
{
    public class Checkout
    {
        private Dictionary<Car, int> _carOrders;

        public Checkout()
        {
            _carOrders = new Dictionary<Car, int>();
        }

        public void AddToCheckout(Car car)
        {
            //Not the best way to check if obj is in dictionary, ideally we would have to implement a hashkey for the object 
            foreach (var keyValue in _carOrders)
            {
                if (keyValue.Key.Equals(car))
                {
                    _carOrders[keyValue.Key] = keyValue.Value + 1;
                    return;
                }
            }
            _carOrders.Add(car, 1);
        }

        public void PrintOrders()
        {
            Console.WriteLine($"{Environment.NewLine}Order consists of the following:");
            foreach (var kv in _carOrders)
            {
                var carInstance = kv.Key;
                var info = $"Car Brand: {carInstance.Brand}{Environment.NewLine}";
                info += $"Car Year: {carInstance.Year:d}{Environment.NewLine}";
                info += $"Car Color: {carInstance.Color}";

              Console.WriteLine($"{info}");
              Console.WriteLine($"Quantity {kv.Value} {Environment.NewLine}");
            }
        }
    }
}
