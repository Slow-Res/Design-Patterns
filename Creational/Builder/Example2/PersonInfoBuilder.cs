using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example2
{
    public class PersonInfoBuilder<Tself>
        : PersonBuilder
        where Tself : PersonInfoBuilder<Tself>
    { 

        public PersonInfoBuilder() {}

        public Tself Called(string name)
        {
            person.Name = name;
            return (Tself) this;
        }

    }
} 