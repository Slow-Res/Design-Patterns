using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example4.Interfaces
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType type);
    }
}