namespace Design_Patterns.Creational.Builder.Example7
{
    public class EmployeeInfoBuilder : EmployeeBuilder
    {
        public EmployeeInfoBuilder(Employee employee)
        {
            this.emp = employee;
        }

        public EmployeeInfoBuilder Called(string name)
        {
            emp.Name = name;
            return this;
        }
        public EmployeeInfoBuilder WithAge(int age)
        {
            emp.Age = age;
            return this;
        }
    }
}