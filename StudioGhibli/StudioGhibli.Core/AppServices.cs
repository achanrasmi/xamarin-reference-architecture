using System;
using ReferenceArchitecture.Core.Infrastructure;
using ReferenceArchitecture.Core.Logging;
using StudioGhibli.Core.Services;

namespace StudioGhibli.Core
{
	public static class AppServices
	{
		public static void Init()
		{
			ServiceContainer.Register<IAPIService>(new APIService());
			ServiceContainer.Register<ILogger>(new SimpleDebugLogger());
		}
	}
}
