namespace Design_Patterns.Creational.Builder.Example4.Interfaces
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int wheels);
    }
}