using src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant
{
    //This low level class shold implement the ILogger interface
    public class DbLogger : ILogger
    {
        public void LogMessage(string aString)
        {
            throw new NotImplementedException();
        }
    }
}
    