using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory.Example4
{
    public interface IProductFactory
    {
        IProduct CreateProduct(ProductType type);
    }
}