using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example6
{
    public abstract class FunctionalBuilder<Tsubject, Tself>
        where Tself : FunctionalBuilder<Tsubject, Tself>
        where Tsubject : new()
    {
        private readonly List<Func<Tsubject, Tsubject>> actions = [];

        public Tsubject Build()
        {
            return actions.Aggregate(new Tsubject(), (p,f) => f(p));
        }

        public Tself Do(Action<Tsubject> action)
        {
            return AddAction(action);
        }

        private Tself AddAction(Action<Tsubject> action)
        {
            actions.Add( p => {
                action(p);
                return p;
            });
            return (Tself) this;
        }
    }
}