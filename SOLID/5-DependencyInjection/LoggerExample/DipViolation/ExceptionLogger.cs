using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipViolation
{
    public class ExceptionLogger
    {
        /***
   
                  Whenever the client wants to introduce a new logger, we must alter the ExceptionLogger class.
                  This happens because the ExceptionLogger class directly contacts the low-level classes FileLogger and DbLogger to log the exception.

                  This way of implementing the logger does not follow the Dependency Inversion Principle
                  because the ExceptionLogger class is directly dependent on the DbLogger class.
        ***/

        public void LogIntoFile(Exception aException)
        {
            FileLogger objFileLogger = new();
            objFileLogger.LogMessage(GetUserReadableMessage(aException));
        }
        //public void LogIntoDb(Exception aException)
        //{
        //    DbLogger objDbLogger = new();
        //    objDbLogger.LogMessage(GetUserReadableMessage(aException));
        //}
        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.

            return strMessage;
        }
    }
}
