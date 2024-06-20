namespace Design_Patterns.Creational.Builder.Example6
{
    public class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name)
        {
            return Do(p => p.Name = name);
        }

        public PersonBuilder WorksAsA(string position)
        {
            return Do(p => p.Position = position);
        }
    }
}