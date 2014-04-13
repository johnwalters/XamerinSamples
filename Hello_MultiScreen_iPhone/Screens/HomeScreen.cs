using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_MultiScreen_iPhone
{
	public partial class HomeScreen : UIViewController
	{
		HelloWorldScreen helloWorldScreen;
		HelloUniverseScreen helloUniverseScreen;

		public HomeScreen () : base ("HomeScreen", null)
		{

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.btnHelloWorld.TouchUpInside += (sender, e) => {
				if (this.helloWorldScreen == null) {
					this.helloWorldScreen = new HelloWorldScreen ();

				}
				this.NavigationController.PushViewController (this.helloWorldScreen, true);
			};

			this.btnHelloUniverse.TouchUpInside += (sender, e) => {
				if (this.helloUniverseScreen == null) {
					this.helloUniverseScreen = new HelloUniverseScreen ();

				}
				this.NavigationController.PushViewController (this.helloUniverseScreen, true);
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);

		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, animated);
		}
	}
}

