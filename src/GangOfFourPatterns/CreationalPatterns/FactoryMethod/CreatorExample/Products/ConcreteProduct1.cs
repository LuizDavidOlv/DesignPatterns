using src.GangOfFourPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;
using System;

namespace src.GangOfFourPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Products
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
