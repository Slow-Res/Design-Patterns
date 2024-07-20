using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design_Patterns.Creational.Builder.Example6;

namespace Design_Patterns.Creational.Prototype.Example1
{
    public class Person
    {
        public string [] Names;
        private Address Address;

        public Person(string [] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person(Person other)
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }

        override public string ToString()
        {
            return $"Names: {string.Join(' ', Names)}, Address: {Address}";
        }
    }
}