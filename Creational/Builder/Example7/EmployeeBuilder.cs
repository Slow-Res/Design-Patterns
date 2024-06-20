namespace Design_Patterns.Creational.Builder.Example7
{
    public class EmployeeBuilder
    {
        protected Employee emp = new();
        public EmployeeJobBuilder Works => new(emp);
        public EmployeeAddressBuilder LivesAt => new(emp);
        public EmployeeInfoBuilder Info => new(emp);

        public static implicit operator Employee(EmployeeBuilder eb) => eb.emp;
    }
}