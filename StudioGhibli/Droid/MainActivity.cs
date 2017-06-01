using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using StudioGhibli.Core;
using ReferenceArchitecture.Core.Infrastructure;

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

		IContainer RegisterNativeDependencies()
		{
			var container = new SimpleIoCContainer();
			//register native dependencies here
			return container;
		}
	}
}
