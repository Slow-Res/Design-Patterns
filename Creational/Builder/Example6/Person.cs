using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example6
{
    public class Person
    {
        public string Name, Position;
        public Address Address { get; set; }

        override public string ToString()
        {
            return $"The {nameof(Name)}: {Name}, Lives in {Address.Country}, {Address.City}, works as {Position}";
        }
    }
}