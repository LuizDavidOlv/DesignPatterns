using src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant
{
    public class ExceptionLogger
    {
        //ExceptionLogger is now loosely coupled with the low-level classes FileLogger and DbLogger. 
        private ILogger _logger;
        public ExceptionLogger(ILogger aLogger)
        {
            this._logger = aLogger;
        }
        public void LogException(Exception aException)
        {
            string strMessage = GetUserReadableMessage(aException);
            this._logger.LogMessage(strMessage);
        }
        private string GetUserReadableMessage(Exception aException)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.
           return strMessage;
        }
    }
}
