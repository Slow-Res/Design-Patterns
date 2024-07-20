using System.Runtime.InteropServices;
using Design_Patterns.Creational.Builder;
using Design_Patterns.Creational.Builder.Example2;
using Design_Patterns.Creational.Builder.Example3;
using Design_Patterns.Creational.Builder.Example4;
using Design_Patterns.Creational.Builder.Example6;
using Design_Patterns.Creational.Builder.Example7;
using Design_Patterns.Creational.Factory.Example2;
using Design_Patterns.Creational.Factory.Example3;
using Design_Patterns.Creational.Factory.Example4;
using Design_Patterns.Creational.Factory.Example5;
using Design_Patterns.Creational.Factory.Example6;
using Design_Patterns.Creational.Prototype.Example2;
using Design_Patterns.Creational.Prototype.Example3;


//InitBuilder();

//InitFactory().GetAwaiter().GetResult();

InitPrototype();


static void InitBuilder()
{

    // EXAMPLE 1
    var items = new[] { "Item1", "Item2", "Item3" };
    var builder = new HtmlBuilder("ul");
    foreach (var item in items)
    {
        builder.AddChild("li", item);
    }

    Console.WriteLine(builder.ToString());

    // EXAMPLE 2 ( Fluent Builder )
    // var person = Person.New
    //         .Called("Abd")
    //         .WorksAsA("Engineer")
    //         .Build();

    //Console.WriteLine(person.ToString());

    // EXAMPLE 3
    var calculator = new Calculator.Builder()
                                   .WithTrigFnctions()
                                   .WithCaseColor("Red")
                                   .Build();
    System.Console.WriteLine(calculator.ToString());

    // EXAMPLE 4
    var car = CarBuilder.Create()
        .OfType(CarType.CrossOver)
        .WithWheels(17)
        .Build();

    // EXAMPLE 6
    var personWithAddress = new Design_Patterns.Creational.Builder.Example6.PersonBuilder()
                                                                           .WithCity("Amman")
                                                                           .Called("Abd")
                                                                           .WithCountry("Jordan")
                                                                           .WithZipCode("21110")
                                                                           .WorksAsA("Engineer")
                                                                           .Build();

    System.Console.WriteLine(personWithAddress.ToString());

    //EXAMPLE 7
    Employee employee = new EmployeeBuilder()
                             .Info.Called("Abd")
                                  .WithAge(30)
                             .Works.WorksAt("TESTO")
                                   .WorksAsA("Developer")
                                   .Earning(100)
                             .LivesAt.Street("AAA")
                                     .WithCity("AMMAN")
                                     .WithPostcode("12345");

    System.Console.WriteLine(employee);
}

static async Task InitFactory()
{
    var p1 = Design_Patterns.Creational.Factory.Example1.Point.NewCartesianPoint(15,20);
    var p2 = Design_Patterns.Creational.Factory.Example1.Point.NewPolarPoint(5, 65);

    var asyncObjectCreationTask = await AsyncObj.CreateAsync("TESTO123");

    var p3 = PointFactory.NewCartesianPoint(15,20);
    var p4 = PointFactory.NewPolarPoint(5, 65);

    var productFactory = new ProductFactory();
    var keyboard = productFactory.CreateProduct(ProductType.Keyboard);
    var mechincalMouse = productFactory.CreateProduct(ProductType.MechincalMouse);

    System.Console.WriteLine(keyboard.Print());
    System.Console.WriteLine(mechincalMouse.Print());

    // Creating factory that tracking and have access to all created objects
    var carsFactory = new CarsFactory();
    carsFactory.CreateCar("BMW", "RED");
    carsFactory.CreateCar("Audi", "Blue");
    carsFactory.CreateCar("Hammer", "Yellow");
    carsFactory.StopAllCreatedCars();
    carsFactory.ReplaceAllCarsWith("BENZ", "BLACK");
    carsFactory.StopAllCreatedCars();

    var machine = new HotDrinkMachine();
    IHotDrink drink = machine.MakeDrink();
    drink.Consume();
}

static void InitPrototype()
{
    // EXAMPLE 1
    // var address = new Design_Patterns.Creational.Prototype.Example1.Address("Street Test", 3);
    // var foo = new Design_Patterns.Creational.Prototype.Example1.Person( new string[] {"Abd", "John"}, address);

    // System.Console.WriteLine(foo);

    // var doe = new Design_Patterns.Creational.Prototype.Example1.Person(foo);
    // doe.Names[1] = "doe";
    // System.Console.WriteLine(doe);


    // EXAMPLE 2
    var Subjects = new string[] { "Math" , "History"};
    var studentInfo = new StudentInfo("Abd", "ALI");
    var std1 = new Student(Subjects , studentInfo );

    System.Console.WriteLine(std1);

    // var std2 = std1.DeepCopy();
    // std2.Subjects[0] = "Physics";
    // std2.StudentInfo.FirstName = "MOH";

    // System.Console.WriteLine(std2);
    // System.Console.WriteLine(std1);

    // Example 3

    Student std3 = std1.DeepCopyBySerialization();

    std3.Subjects[0] = "English";

    System.Console.WriteLine(std3);
    System.Console.WriteLine(std1);


}