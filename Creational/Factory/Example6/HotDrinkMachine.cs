namespace Design_Patterns.Creational.Factory.Example6
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink // violates open-closed
        {
            Coffee, Tea
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories = [];

        private List<Tuple<string, IHotDrinkFactory>> namedFactories = [];

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    var hotDrinkFactory = Activator.CreateInstance(t) as IHotDrinkFactory;
                    var setName =  t.Name.Replace("Factory", string.Empty);
                    namedFactories.Add(new(setName, hotDrinkFactory));
                }
            }
        }

        public IHotDrink MakeDrink(string type)
        {
            return type switch
            {
                "tea" => new TeaFactory().Prepare(200),
                "coffee" => new CoffeeFactory().Prepare(50),
                _ => throw new ArgumentException("type"),
            };
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks");
            for (var index = 0; index < namedFactories.Count; index++)
            {
                var tuple = namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");

            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i) // c# 7
                    && i >= 0
                    && i < namedFactories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return namedFactories[i].Item2.Prepare(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again.");
            }
        }
    }
}