using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example5
{
    public sealed class PersonBuilder
    {
        private readonly List<Func<Person, Person>> actions = [];

        public Person Build()
        {
            return actions.Aggregate(new Person(), (p,f) => f(p));
        }

        public PersonBuilder Called(string name)
        {
            return Do( p => p.Name = name);
        }

        public PersonBuilder Do(Action<Person> action)
        {
            return AddAction(action);
        }

        private PersonBuilder AddAction(Action<Person> action)
        {
            actions.Add( p => {
                action(p);
                return p;
            });
            return this;
        }
    }
}