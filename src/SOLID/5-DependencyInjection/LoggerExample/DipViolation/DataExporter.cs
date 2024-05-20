using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipViolation
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to the database.
            }
            //catch (IOException ex)
            //{
            //    new ExceptionLogger().LogIntoDataBase(ex);
            //}
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }

        }
    }
}
