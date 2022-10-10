using System;

namespace Generics_Delegates_Exercise
{
    public class Car : IEquatable<Car>
    { 
        public Brand CarBrand { get; set; }
        public DateTime Year { get; set; }  
        public Color CarColor { get; set; }

        public bool Equals(Car other)
        {
            return CarBrand ==  other.CarBrand && Year == other.Year && CarColor == other.CarColor; 
        }
    }
}
