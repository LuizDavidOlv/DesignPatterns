using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant
{
    public class DataExporter
    {
        //By making ExceptionLogger loosely coupled, we are giving provision to DataExport class to decide what
        //kind of Logger should be called based on the exception that occurs.

        //Just create a new Logger named WantToAddNewLogger. Just create a catch block in DataExporter and that's it.

        public void ExportDataFromFile()
        {
            ExceptionLogger _exceptionLogger;
            try
            {
                //code to export data from files to database.
            }
            catch (IOException ex)
            {
                _exceptionLogger = new ExceptionLogger(new DbLogger());
                _exceptionLogger.LogException(ex);
            }
            catch (ArgumentNullException ex)
            {
                _exceptionLogger = new ExceptionLogger(new WantToAddNewLogger());
                _exceptionLogger.LogException(ex);
            }
            catch (Exception ex)
            {
                _exceptionLogger = new ExceptionLogger(new FileLogger());
                _exceptionLogger.LogException(ex);
            }
        }
    }
}
