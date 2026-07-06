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
	[Register ("TableViewController")]
	partial class TableViewController
	{
		[Outlet]
		AppKit.NSTableColumn Name { get; set; }

		[Outlet]
		AppKit.NSTableColumn Occupation { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Occupation != null) {
				Occupation.Dispose ();
				Occupation = null;
			}

			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

		}
	}
}
