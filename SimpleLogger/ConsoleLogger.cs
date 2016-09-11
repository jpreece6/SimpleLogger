using System;

namespace SimpleLogger
{
    public class ConsoleLogger : ISimpleLogger
    {
        public virtual void Write(string message, LogLevel level = LogLevel.Info)
        {
            Console.WriteLine($"{level}: {message}");
        }

        public virtual void WriteError(string message, Exception exceptionObj, LogLevel level = LogLevel.Error)
        {
            Console.WriteLine($"{level}: {message}\n\nException:\n{exceptionObj.StackTrace}");
        }
    }
}
