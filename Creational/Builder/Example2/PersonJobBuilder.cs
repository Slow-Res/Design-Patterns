using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example2
{
    public class PersonJobBuilder<Tself>
        : PersonInfoBuilder<PersonJobBuilder<Tself>>
        where Tself : PersonJobBuilder<Tself>
    {
        public Tself WorksAsA(string Position)
        {
            person.Position = Position;
            return (Tself) this;
        }
    }
}