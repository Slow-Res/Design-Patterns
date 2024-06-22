namespace Design_Patterns.Creational.Factory.Example4
{
    public interface IProduct
    {
        string Name { get; }
        string Category { get; }
        string GetSerialNumber();
        DateOnly GetProductionDate();

        string Print();
    }
}