using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.CreationalPatterns.AbstractFactory.CreatorExample
{
    public class AbstractFactory
    {
        public static void Execute()
        {
            new Client().Main();
        }
    }
}
