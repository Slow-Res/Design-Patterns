using Design_Patterns.Creational.Builder;


InitBuilder();



static void InitBuilder()
{
    var items = new[] { "Item1", "Item2", "Item3" };

    var builder = new HtmlBuilder("ul");
    foreach (var item in items)
    {
        builder.AddChild("li", item);
    }

    Console.WriteLine(builder.ToString());
    
}