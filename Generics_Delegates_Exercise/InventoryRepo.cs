using System;
using System.Collections.Generic;

namespace Generics_Delegates_Exercise
{
    //Just assume this is coming from a data source
    internal static class InventoryRepo
    {
        static int id = 0;

        public static Dictionary<int, Car> InventoryCars = new Dictionary<int, Car>()
            {
                { ++id, new Car()
                    {
                        CarBrand = Brand.Toyota,
                        Year = DateTime.Today,
                        CarColor =  Color.Silver
                    }
                },
                { ++id, new Car()
                    {
                        CarBrand = Brand.Tesla,
                        Year = DateTime.Today.AddDays(-19),
                        CarColor =  Color.White
                    }
                },
            };

        public static Dictionary<int, MotorBike> InventoryBikes = new Dictionary<int, MotorBike>()
            {
                { ++id, new MotorBike()
                    {
                        MotorBikeBrand = Brand.Honda,
                        Year = DateTime.Today,
                        MotorBikeColor =  Color.Silver
                    }
                },
                { ++id, new MotorBike()
                    {
                        MotorBikeBrand = Brand.BMW,
                        Year = DateTime.Today.AddDays(-19),
                        MotorBikeColor =  Color.White
                    }
                },
            };

    }
}
