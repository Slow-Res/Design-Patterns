namespace Design_Patterns.Creational.Builder.Example7
{
    public class EmployeeJobBuilder : EmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            this.emp = employee;
        }

        public EmployeeJobBuilder WorksAt(string name)
        {
            emp.CompanyName = name;
            return this;
        }

        public EmployeeJobBuilder WorksAsA(string name)
        {
            emp.Position = name;
            return this;
        }

        public EmployeeJobBuilder Earning(int income)
        {
            emp.Income = income;
            return this;
        }
    }
}