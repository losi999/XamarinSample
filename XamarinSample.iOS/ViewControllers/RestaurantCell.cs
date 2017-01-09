using System;

using Foundation;
using UIKit;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.iOS.ViewControllers {
    public partial class RestaurantCell : UITableViewCell {
        public static readonly NSString Key = new NSString("RestaurantCell");
        public static readonly UINib Nib;



        static RestaurantCell() {
            //Nib = UINib.FromName("RestaurantCell", NSBundle.MainBundle);
        }

        protected RestaurantCell(IntPtr handle) : base(handle) {
            // Note: this .ctor should not contain any initialization logic.
        }


        public void Set(RestaurantItemModel restaurant) {
            labelId.Text = restaurant.Name + restaurant.Name; //restaurant.Id.ToString();
            labelId.LineBreakMode = UILineBreakMode.WordWrap;
            //labelName.Text = restaurant.Name + restaurant.Name;
            //labelUrl.Text = restaurant.Url;
        }
    }
}
