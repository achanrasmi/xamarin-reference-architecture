using System;

namespace ReferenceArchitecture.Core.Logging
{
	/// <summary>
	/// Simple logger.
	/// </summary>
	public class SimpleDebugLogger : ILogger
	{
		readonly ILogWriter<SimpleDebugLogEvent> writer;

		public SimpleDebugLogger(ILogWriter<SimpleDebugLogEvent> writer)
		{
			this.writer = writer;
			writer.CreateFile();
		}

		public void Verbose(string tag, string message, Exception exception = null)
		{
			WriteToConsole(LogLevel.V, tag, message, exception);
		}

		public void Debug(string tag, string message, Exception exception = null)
		{
			WriteToConsole(LogLevel.D, tag, message, exception);
		}

		public void Info(string tag, string message, Exception exception = null)
		{
			WriteToConsole(LogLevel.I, tag, message, exception);
		}

		public void Warning(string tag, string message, Exception exception = null)
		{
			WriteToConsole(LogLevel.W, tag, message, exception);
		}

		public void Error(string tag, string message, Exception exception = null)
		{
			WriteToConsole(LogLevel.E, tag, message, exception);
		}

		void WriteToConsole(LogLevel logLevel, string tag, string message, Exception ex)
		{
			System.Diagnostics.Debug.WriteLine($"{logLevel.ToString().ToUpperInvariant()}: {tag} - {message}");

			if (ex != null) { System.Diagnostics.Debug.WriteLine(ex.StackTrace); }

			writer.WriteToFile(new SimpleDebugLogEvent(logLevel, tag, message, ex));
		}
	}
}
