# SimpleLogger
I found the need for a logging class in multiple projects. Log4Net seemed overkill hence the requirement. SimpleLogger allows you to choose the output source when creating an instance of the logger.

This library can currently log to:
- Console
- EventLog
- Debug Console

##### Console Logging
```
var logger = new SimpleLogger(new ConsoleLogger());
logger.Write("Some Message");
```

##### EventLog Logging
```
var logger = new SimpleLogger(new EventLogger("SourceName");
logger.Write("Print to the eventlog");
```