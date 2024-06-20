using System.Runtime.InteropServices;
using Design_Patterns.Creational.Builder;
using Design_Patterns.Creational.Builder.Example2;
using Design_Patterns.Creational.Builder.Example3;
using Design_Patterns.Creational.Builder.Example4;
using Design_Patterns.Creational.Builder.Example6;
using Design_Patterns.Creational.Builder.Example7;


InitBuilder();



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