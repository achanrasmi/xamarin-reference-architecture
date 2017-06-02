
using Android.App;
using Android.Content.PM;
using Android.OS;
using ReferenceArchitecture.Core.Logging;
using ReferenceArchitecture.Droid.Logging;
using SimpleInjector;
using StudioGhibli.Core;

namespace StudioGhibli.Droid
{
	[Activity(Label = "StudioGhibli.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			AppInitializer.Init(RegisterNativeDependencies());
			LoadApplication(new App());
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
