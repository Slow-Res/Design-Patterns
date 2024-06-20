using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example2
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public class Builder : PersonJobBuilder<Builder>
        {

        }

        public static Builder New => new Builder();
        override public string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}