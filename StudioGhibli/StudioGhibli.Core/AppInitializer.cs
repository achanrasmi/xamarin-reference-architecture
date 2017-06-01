using System;
using ReferenceArchitecture.Core.Infrastructure;
using ReferenceArchitecture.Core.Logging;
using StudioGhibli.Core.Services;

namespace StudioGhibli.Core
{
	public static class AppInitializer
	{
		public static void Init(IContainer container)
		{
			container.Register<IAPIService, APIService>();
			container.Register<ILogger, SimpleDebugLogger>();
		}
	}
}
