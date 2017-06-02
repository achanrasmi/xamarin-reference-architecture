using System;
namespace ReferenceArchitecture.Core.Logging
{
	public interface ILogWriter<T>
	{
		void CreateFile();
		void WriteToFile(T log);
	}
}
