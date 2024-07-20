namespace Design_Patterns.Creational.Prototype.Example1
{
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address(Address other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }

        override public string ToString()
        {
            return $"StreetNumber: {StreetName}, HouseNumber: {HouseNumber}";
        }
    }
}