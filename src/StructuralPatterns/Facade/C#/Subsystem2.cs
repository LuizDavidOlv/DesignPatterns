using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.DesignPatterns.StructuralPatterns.Facade.C_
{
    public class Subsystem2
    {
        public string Operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string OperationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}
