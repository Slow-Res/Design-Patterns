using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example5
{
    public class Car
    {
        public int Speed { get; set; }
        public string Color { get; set; }

        public string Name { get; set; }
        private string Id = Guid.NewGuid().ToString();
        public Car(string name, string color)
        {
            Name = name;
            Color = color;
            this.Speed = 15;
        }

        public void Stop()
        {
            System.Console.WriteLine($"The {Color} Car With Plate {Id} is stopping");
            this.Speed = 0;
        }
    }
}