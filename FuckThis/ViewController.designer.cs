// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FuckThis
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ClickedLabel1 { get; set; }

		[Outlet]
		AppKit.NSScrollView DocumentEditor { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickedLabel1 != null) {
				ClickedLabel1.Dispose ();
				ClickedLabel1 = null;
			}

			if (DocumentEditor != null) {
				DocumentEditor.Dispose ();
				DocumentEditor = null;
			}
		}
	}
}
