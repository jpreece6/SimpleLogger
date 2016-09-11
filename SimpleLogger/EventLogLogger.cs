using System;
using System.Diagnostics;

namespace SimpleLogger
{
    public class EventLogLogger : ISimpleLogger
    {
        private string _source;

        public string Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public EventLogLogger(string src)
        {
            Source = src;
        }


        public virtual void Write(string message, LogLevel level = LogLevel.Info)
        {
            EventLog.WriteEntry(Source,message, LogLevelToEventLog(level));
        }

        public virtual void WriteError(string message, Exception exceptionObj, LogLevel level = LogLevel.Error)
        {
            EventLog.WriteEntry(Source, $"{message}\n\nException: \n{exceptionObj.StackTrace}", LogLevelToEventLog(level));
        }

        private EventLogEntryType LogLevelToEventLog(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Info:
                    return EventLogEntryType.Information;
                case LogLevel.Warning:
                    return EventLogEntryType.Warning;
                case LogLevel.Error:
                    return EventLogEntryType.Error;
                case LogLevel.Debug:
                    return EventLogEntryType.Information;
                default:
                    return EventLogEntryType.Information;
            }
        }
    }
}
