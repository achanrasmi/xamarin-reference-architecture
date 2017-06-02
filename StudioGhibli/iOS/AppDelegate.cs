
using Foundation;
using ReferenceArchitecture.Core.Logging;
using ReferenceArchitecture.iOS.Logging;
using SimpleInjector;
using StudioGhibli.Core;
using UIKit;

namespace StudioGhibli.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			AppInitializer.Init(RegisterNativeDependencies());
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		Container RegisterNativeDependencies()
		{
			var container = new Container();
			//register native dependencies here
			container.RegisterSingleton<ILogWriter<SimpleDebugLogEvent>, SimpleDebugWriter>();
			return container;
		}
	}
}
