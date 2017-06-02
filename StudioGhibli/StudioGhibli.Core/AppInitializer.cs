using ReferenceArchitecture.Core.Logging;
using SimpleInjector;
using StudioGhibli.Core.Services;

namespace StudioGhibli.Core
{
	public static class AppInitializer
	{
		public static void Init(Container container)
		{
			container.RegisterSingleton<IAPIService, APIService>();
			container.RegisterSingleton<ILogger, SimpleDebugLogger>();

			container.Verify();
		}
	}
}
