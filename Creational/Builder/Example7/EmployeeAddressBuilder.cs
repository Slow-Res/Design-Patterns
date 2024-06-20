namespace Design_Patterns.Creational.Builder.Example7
{
    public class EmployeeAddressBuilder : EmployeeBuilder
    {
        public EmployeeAddressBuilder(Employee employee)
        {
            this.emp = employee;
            emp.Address ??= new();
        }
        public EmployeeAddressBuilder Street(string name)
        {
            emp.Address.StreetAddress = name;
            return this;
        }
        public EmployeeAddressBuilder WithPostcode(string name)
        {
            emp.Address.Postcode = name;
            return this;
        }
        public EmployeeAddressBuilder WithCity(string name)
        {
            emp.Address.City = name;
            return this;
        }
    }
}