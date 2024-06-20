using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example5
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA(this PersonBuilder builder, string position)
        {
            return builder.Do( p => p.Position = position);
        }
    }
}