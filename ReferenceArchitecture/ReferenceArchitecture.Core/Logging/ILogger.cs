using System;
namespace ReferenceArchitecture.Core.Logging
{
	/// <summary>
	/// Interface for custom Logger.
	/// </summary>
	public interface ILogger
	{
		/// <summary>
		/// Log a verbose event
		/// </summary>
		/// <returns>The verbose.</returns>
		/// <param name="tag">Tag.</param>
		/// <param name="message">Message.</param>
		/// <param name="exception">Exception.</param>
		void Verbose(string tag, string message, Exception exception = null);

		/// <summary>
		/// Log a Debug event
		/// </summary>
		/// <returns>The debug.</returns>
		/// <param name="tag">Tag.</param>
		/// <param name="message">Message.</param>
		/// <param name="exception">Exception.</param>
		void Debug(string tag, string message, Exception exception = null);

		/// <summary>
		/// Log an Info event
		/// </summary>
		/// <returns>The info.</returns>
		/// <param name="tag">Tag.</param>
		/// <param name="message">Message.</param>
		/// <param name="exception">Exception.</param>
		void Info(string tag, string message, Exception exception = null);

		/// <summary>
		/// Log a Warning event
		/// </summary>
		/// <returns>The warning.</returns>
		/// <param name="tag">Tag.</param>
		/// <param name="message">Message.</param>
		/// <param name="exception">Exception.</param>
		void Warning(string tag, string message, Exception exception = null);

		/// <summary>
		/// Log an Error event
		/// </summary>
		/// <returns>The error.</returns>
		/// <param name="tag">Tag.</param>
		/// <param name="message">Message.</param>
		/// <param name="exception">Exception.</param>
		void Error(string tag, string message, Exception exception = null);
	}
}
