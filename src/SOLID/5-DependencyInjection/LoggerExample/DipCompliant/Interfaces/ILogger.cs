using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._5_DependencyInjection.LoggerExample.DipCompliant.Interfaces
{
    public interface ILogger
    {
        void LogMessage(string aString);
    }
}
