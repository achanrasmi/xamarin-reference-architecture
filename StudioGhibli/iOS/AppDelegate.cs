using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
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
			AppServices.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
