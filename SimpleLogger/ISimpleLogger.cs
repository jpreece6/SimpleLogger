using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public interface ISimpleLogger
    {
        void Write(string message, LogLevel level = LogLevel.Info);
        void WriteError(string message, Exception exceptionObj, LogLevel level = LogLevel.Error);
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Debug
    }
}
