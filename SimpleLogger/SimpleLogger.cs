using System;
using System.Diagnostics;

namespace SimpleLogger
{
    public class SimpleLogger : ISimpleLogger
    {
        /// <summary>
        /// Writes message to output
        /// </summary>
        /// <param name="message">Message to write</param>
        /// <param name="level">Level of message</param>
        public virtual void Write(string message, LogLevel level = LogLevel.Info)
        {
            Debug.Print($"{level}: {message}");
        }

        /// <summary>
        /// Writes message to output with exception details
        /// </summary>
        /// <param name="message">Message to write</param>
        /// <param name="exceptionObj">Exception object with exception details</param>
        /// <param name="level">Level to print</param>
        public virtual void WriteError(string message, Exception exceptionObj, LogLevel level = LogLevel.Error)
        {
            Debug.Print($"{level}: {message}\n\nException: \n{exceptionObj.StackTrace}");
        }
    }
}
