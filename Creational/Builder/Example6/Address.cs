using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example6
{
    public class Address
    {
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
    }
}