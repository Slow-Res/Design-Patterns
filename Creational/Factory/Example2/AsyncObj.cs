using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example2
{
    public class AsyncObj
    {
        public string Name { get; set; }
        private AsyncObj(string name) { Name = name; }
        private async Task<AsyncObj> InitAsync()
        {
            System.Console.WriteLine("Creating Object Async ...");
            await Task.Delay(1000);
            System.Console.WriteLine($@"The object {Name} created!");
            return this;
        }
        public static Task<AsyncObj> CreateAsync(string name)
        {
            var obj = new AsyncObj(name);
            return obj.InitAsync();
        }
    }
}