using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example7
{

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string CompanyName { get; set; }
        public int Income { get; set; }
        public string Position { get; set; }

        public EmployeeAddress Address { get; set; }

        public override string ToString()
        {
            return (
                $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Company Name: {CompanyName}\n" +
                $"Income: {Income}\n" +
                $"Position: {Position}\n" +
                $"Address: {Address.City}, {Address.StreetAddress}, {Address.Postcode}"
            );
        }

    }
}