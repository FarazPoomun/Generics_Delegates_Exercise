using System;

namespace Generics_Delegates_Exercise
{
    public class MotorBike : IEquatable<MotorBike>
    {
        public Brand MotorBikeBrand { get; set; }
        public DateTime Year { get; set; }
        public Color MotorBikeColor { get; set; }

        public bool Equals(MotorBike other)
        {
            return MotorBikeBrand == other.MotorBikeBrand && Year == other.Year && MotorBikeColor == other.MotorBikeColor;
        }
    }
}
