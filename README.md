# SimpleLogger
I found the need for a logging class in multiple projects. Log4Net seemed overkill hence the requirement. SimpleLogger allows you to choose the output source when creating an instance of the logger.

This library can currently log to:
- Console
- EventLog
- Debug Console

##### Console Logging
Basic example
```
var logger = new SimpleLogger(new ConsoleLogger());
logger.Write("Some Message");
```
Or
```
var logger = new SimpleLogger(new ConsoleLogger());
logger.Write("Some Message", Warning);
```
###### Output
"Info: Some Message"

"Warning: Some Message"


##### EventLog Logging
```
var logger = new SimpleLogger(new EventLogger("SourceName");
logger.Write("Print to the eventlog");
```
###### Output
Source: SourceName

Print to the eventlog
##### Logging Exceptions 
```
try {
	DoBrokenMethod();
} catch(NullReferenceException nullRef) {
	logger.WriteError("Method X failed", nullRef);
}
```
###### Output
Method X failed

Exception: Nullreference (stack trace)