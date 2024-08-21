using src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant.Interfaces;
using System;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant
{
    public class WantToAddNewLogger : ILogger
    {
        public void LogMessage(string aString)
        {
            throw new NotImplementedException();
        }
    }
}
