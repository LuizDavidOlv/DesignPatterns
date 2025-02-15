using src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;
using System;

namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Products
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
