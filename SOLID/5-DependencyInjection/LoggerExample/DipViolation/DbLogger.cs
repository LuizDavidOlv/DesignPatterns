using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipViolation
{
    public class DbLogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in the database.
        }
    }
}
