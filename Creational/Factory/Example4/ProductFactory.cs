using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example4
{
    public class ProductFactory : IProductFactory
    {
        public IProduct CreateProduct(ProductType type)
        {
            return type switch
            {
                ProductType.Mouse => new Mouse("Regular Mouse", "Electronics"),
                ProductType.MechincalMouse => new Mouse("Mechincal Mouse", "Electronics"),
                ProductType.Keyboard => new Keyboard("Regular Keyboard", "Electronics"),
                ProductType.MechincalKeyboard => new Mouse("Mechincal Keyboard", "Electronics"),
                _ => throw new ArgumentException($"Type {type} is not allowed"),
            };
        }
    }
}