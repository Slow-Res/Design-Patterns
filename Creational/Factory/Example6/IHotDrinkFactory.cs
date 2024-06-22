namespace Design_Patterns.Creational.Factory.Example6
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}