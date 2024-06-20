using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example2
{
    public abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build()
        {
            return person;
        }
    }
}