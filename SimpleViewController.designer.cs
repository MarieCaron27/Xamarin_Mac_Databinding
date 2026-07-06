// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace liaison_donnees
{
	[Register ("SimpleViewController")]
	partial class SimpleViewController
	{
		[Outlet]
		AppKit.NSButton isManager { get; set; }

		[Outlet]
		AppKit.NSTextField Name { get; set; }

		[Outlet]
		AppKit.NSTextField NumberOfEmployees { get; set; }

		[Outlet]
		AppKit.NSTextField Occupation { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

			if (Occupation != null) {
				Occupation.Dispose ();
				Occupation = null;
			}

			if (isManager != null) {
				isManager.Dispose ();
				isManager = null;
			}

			if (NumberOfEmployees != null) {
				NumberOfEmployees.Dispose ();
				NumberOfEmployees = null;
			}

		}
	}
}
