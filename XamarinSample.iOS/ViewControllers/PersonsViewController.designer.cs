// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinSample.iOS.ViewControllers
{
    [Register ("PersonsViewController")]
    partial class PersonsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonListPersons { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonNewPerson { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPersonCount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonListPersons != null) {
                buttonListPersons.Dispose ();
                buttonListPersons = null;
            }

            if (buttonNewPerson != null) {
                buttonNewPerson.Dispose ();
                buttonNewPerson = null;
            }

            if (labelPersonCount != null) {
                labelPersonCount.Dispose ();
                labelPersonCount = null;
            }
        }
    }
}