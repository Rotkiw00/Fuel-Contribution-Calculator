// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Nawache
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel appNameHeader { get; set; }

		[Outlet]
		UIKit.UILabel costWithoutWeightLabel { get; set; }

		[Outlet]
		UIKit.UILabel costWithWeightLabel { get; set; }

		[Outlet]
		UIKit.UIButton distanceInfoButton { get; set; }

		[Outlet]
		UIKit.UITextField distanceInputTextField { get; set; }

		[Outlet]
		UIKit.UIButton fuelCostInfoButton { get; set; }

		[Outlet]
		UIKit.UITextField fuelCostInputTextField { get; set; }

		[Outlet]
		UIKit.UIButton milageInfoButton { get; set; }

		[Outlet]
		UIKit.UITextField milageInputTextField { get; set; }

		[Outlet]
		UIKit.UIButton peopleInfoButton { get; set; }

		[Outlet]
		UIKit.UITextField peopleInputTextField { get; set; }

		[Outlet]
		UIKit.UILabel printResultLabel1 { get; set; }

		[Outlet]
		UIKit.UILabel printResultLabel2 { get; set; }

		[Outlet]
		UIKit.UIButton weightInfoButton { get; set; }

		[Outlet]
		UIKit.UITextField weightPeopleInputTextField { get; set; }

		[Action ("generateResultButton:")]
		partial void generateResultButton (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (appNameHeader != null) {
				appNameHeader.Dispose ();
				appNameHeader = null;
			}

			if (costWithoutWeightLabel != null) {
				costWithoutWeightLabel.Dispose ();
				costWithoutWeightLabel = null;
			}

			if (costWithWeightLabel != null) {
				costWithWeightLabel.Dispose ();
				costWithWeightLabel = null;
			}

			if (distanceInfoButton != null) {
				distanceInfoButton.Dispose ();
				distanceInfoButton = null;
			}

			if (distanceInputTextField != null) {
				distanceInputTextField.Dispose ();
				distanceInputTextField = null;
			}

			if (fuelCostInfoButton != null) {
				fuelCostInfoButton.Dispose ();
				fuelCostInfoButton = null;
			}

			if (fuelCostInputTextField != null) {
				fuelCostInputTextField.Dispose ();
				fuelCostInputTextField = null;
			}

			if (milageInfoButton != null) {
				milageInfoButton.Dispose ();
				milageInfoButton = null;
			}

			if (milageInputTextField != null) {
				milageInputTextField.Dispose ();
				milageInputTextField = null;
			}

			if (peopleInfoButton != null) {
				peopleInfoButton.Dispose ();
				peopleInfoButton = null;
			}

			if (peopleInputTextField != null) {
				peopleInputTextField.Dispose ();
				peopleInputTextField = null;
			}

			if (printResultLabel1 != null) {
				printResultLabel1.Dispose ();
				printResultLabel1 = null;
			}

			if (printResultLabel2 != null) {
				printResultLabel2.Dispose ();
				printResultLabel2 = null;
			}

			if (weightInfoButton != null) {
				weightInfoButton.Dispose ();
				weightInfoButton = null;
			}

			if (weightPeopleInputTextField != null) {
				weightPeopleInputTextField.Dispose ();
				weightPeopleInputTextField = null;
			}
		}
	}
}
