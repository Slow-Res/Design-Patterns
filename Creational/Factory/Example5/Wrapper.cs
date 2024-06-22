using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example5
{
    public class Wrapper<T> where T: class
    {
        public T Value;
        public Wrapper(T value)
        {
            Value = value;
        }
    }
}