// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace PickerExample
{
	[Register ("PickerExampleViewController")]
	partial class PickerExampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField color { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (color != null) {
				color.Dispose ();
				color = null;
			}
		}
	}
}
