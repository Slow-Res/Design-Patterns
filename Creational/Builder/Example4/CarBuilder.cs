using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design_Patterns.Creational.Builder.Example4.Interfaces;

namespace Design_Patterns.Creational.Builder.Example4
{
    public class CarBuilder
    {
        private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new();
            public Car Build()
            {
                return car;
            }

            public ISpecifyWheelSize OfType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch(car.Type)
                {
                    case CarType.CrossOver when size < 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                      throw new ArgumentException($"Wrong size of wheel for {car.Type}");
                }
                car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}