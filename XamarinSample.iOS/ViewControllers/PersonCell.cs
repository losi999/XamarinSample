using System;

using Foundation;
using UIKit;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonCell : UITableViewCell {
        public static readonly NSString Key = new NSString("PersonCell");
        public static readonly UINib Nib;

        static PersonCell() {
            Nib = UINib.FromName("PersonCell", NSBundle.MainBundle);
        }

        protected PersonCell(IntPtr handle) : base(handle) {
            // Note: this .ctor should not contain any initialization logic.
        }

        public UILabel LabelName => labelName;
        public UILabel LabelAge => labelAge;
        public UILabel LabelGender => labelGender;
        public UILabel LabelAddress => labelAddress;
        public UILabel LabelEMail => labelEMail;
        public UILabel LabelPhoneNumber => labelPhoneNumber;
    }
}
