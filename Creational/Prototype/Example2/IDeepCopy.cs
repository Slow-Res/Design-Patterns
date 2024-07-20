using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Example2
{
    public interface IDeepCopy<T>
    {
        T DeepCopy();
    }
}