﻿namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
