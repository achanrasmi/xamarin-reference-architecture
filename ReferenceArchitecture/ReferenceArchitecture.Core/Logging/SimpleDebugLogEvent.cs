using System;
namespace ReferenceArchitecture.Core.Logging
{
	public class SimpleDebugLogEvent
	{
		public LogLevel Level { get; }
		public string Tag { get; }
		public string Message { get; }
		public Exception Error { get; }

		public SimpleDebugLogEvent(LogLevel level, string tag, string message, Exception ex)
		{
			Level = level;
			Tag = tag;
			Message = message;
			Error = ex;
		}
	}
}
