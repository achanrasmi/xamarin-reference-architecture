using NUnit.Framework;
using System;
using ReferenceArchitecture.Core.Logging;
using System.Collections.Generic;

namespace ReferenceArchitecture.UnitTest
{
	[TestFixture]
	public class SimpleDebugLoggerTest
	{
		TestWriter testWriter;
		SimpleDebugLogger logger;

		// Test variables
		string testTag = "Test Tag";
		string testMessage = "Test Message";
		Exception testException = new NullReferenceException();

		[SetUp]
		public void Setup()
		{
			testWriter = new TestWriter();
			logger = new SimpleDebugLogger(testWriter);
		}

		[TearDown]
		public void TearDown()
		{
			testWriter = null;
			logger = null;
		}

		[Test]
		public void ShouldCreateFileWhenConstructed()
		{
			Assert.IsNotNull(testWriter.TestEvents);
		}

		[Test]
		public void ShouldWriteLogsToLogWriter()
		{
			logger.Verbose(testTag, testMessage, testException);
			logger.Debug(testTag, testMessage, testException);
			logger.Info(testTag, testMessage, testException);
			logger.Warning(testTag, testMessage, testException);
			logger.Error(testTag, testMessage, testException);
			Assert.IsTrue(testWriter.TestEvents.Count == 5);
		}

		[Test]
		public void ShouldWriteCorrectLoggingLevel()
		{
			logger.Verbose(testTag, testMessage, testException);
			logger.Debug(testTag, testMessage, testException);
			logger.Info(testTag, testMessage, testException);
			logger.Warning(testTag, testMessage, testException);
			logger.Error(testTag, testMessage, testException);
			Assert.IsTrue(testWriter.TestEvents[0].Level == LogLevel.V);
			Assert.IsTrue(testWriter.TestEvents[1].Level == LogLevel.D);
			Assert.IsTrue(testWriter.TestEvents[2].Level == LogLevel.I);
			Assert.IsTrue(testWriter.TestEvents[3].Level == LogLevel.W);
			Assert.IsTrue(testWriter.TestEvents[4].Level == LogLevel.E);
		}

		class TestWriter : ILogWriter<SimpleDebugLogEvent>
		{
			public List<SimpleDebugLogEvent> TestEvents { get; private set; }

			public void CreateFile()
			{
				TestEvents = new List<SimpleDebugLogEvent>();
			}

			public void WriteToFile(SimpleDebugLogEvent log)
			{
				TestEvents.Add(log);
			}
		}
	}
}
