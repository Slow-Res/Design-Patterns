using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example5
{
    public class CarsFactory
    {
        public List<WeakReference<Wrapper<Car>>> CurrentCars { get; set; } = [];

        public Car CreateCar(string carName, string color)
        {
            Car car = new(carName, color);
            var carRef = new Wrapper<Car>(car);
            CurrentCars.Add(new(carRef));
            return car;
        }

        public void StopAllCreatedCars()
        {
            foreach (var car in CurrentCars)
            {
                if (car.TryGetTarget(out var carRef))
                {
                    carRef.Value.Stop();
                }
            }
        }

        public void ReplaceAllCarsWith(string carName, string color)
        {
            foreach (var car in CurrentCars)
            {
                if (car.TryGetTarget(out var carRef))
                {
                    carRef.Value = new Car(carName, color);
                }
            }
        }
    }
}