using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ReferenceArchitecture.Core.Infrastructure;
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

		IContainer RegisterNativeDependencies()
		{
			var container = new SimpleIoCContainer();
			//register native dependencies here
			return container;
		}
	}
}
