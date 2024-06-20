using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example6
{
    public static class PersonAddressBuilderExtenions
    {
        public static PersonBuilder WithCountry(this PersonBuilder builder, string country)
        {
            return builder.Do(p =>
            {
                p.Address ??= new Address();
                p.Address.Country = country;
            });
        }

        public static PersonBuilder WithCity(this PersonBuilder builder, string city)
        {
            return builder.Do(p =>
            {
                p.Address ??= new Address();
                p.Address.City = city;
            });
        }

        public static PersonBuilder WithZipCode(this PersonBuilder builder, string zipcode)
        {
            return builder.Do(p =>
            {
                p.Address ??= new Address();
                p.Address.Zipcode = zipcode;
            });
        }
    }
}