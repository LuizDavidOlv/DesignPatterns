using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.DesignPatterns.StructuralPatterns.Facade.C_
{
    public class Facade
    {
        // The Facade class provides a simple interface to the complex logic of one or several subsystems.
        // The Facade delegates the client requests to the appropriate objects within the subsystem.
        // The Facade is also responsible for managin their lifecycle.
        // All of this shields the client from the undesired complexity of the subsystem.

        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }


        // The Facade's methods are covenient shortcuts to the sophisticated functionality of the subsystems.
        // However, clients get only to a fraction of a subsytem's capabilities.

        public string Operation()
        {

           string result = "Facade initializes subsystems:\n";
            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _subsystem1.OperationN();
            result += _subsystem2.OperationZ();
            return result;
        }
    }
}
