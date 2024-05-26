using src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;
using System;

namespace src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Products
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
