// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Hello_MultiScreen_iPhone
{
	[Register ("HomeScreen")]
	partial class HomeScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnHelloUniverse { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnHelloWorld { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnHelloWorld != null) {
				btnHelloWorld.Dispose ();
				btnHelloWorld = null;
			}

			if (btnHelloUniverse != null) {
				btnHelloUniverse.Dispose ();
				btnHelloUniverse = null;
			}
		}
	}
}
