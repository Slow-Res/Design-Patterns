using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example4
{
    public class Mouse : IProduct
    {
        public string Name {get;}

        public string Category {get;}

        public Mouse(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public DateOnly GetProductionDate()
        {
            return DateOnly.FromDateTime(DateTime.Now);
        }

        public string GetSerialNumber()
        {
            return Guid.NewGuid().ToString();
        }
        public string Print()
        {
            return $@"Product ({Category}):{Name}";
        }
    }
}