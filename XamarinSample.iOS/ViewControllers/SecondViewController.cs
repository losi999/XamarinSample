using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.ViewModel;
using Foundation;

namespace XamarinSample.iOS.ViewControllers {
    public partial class SecondViewController : ViewControllerBase<ISecondViewModel> {
        protected override ISecondViewModel ViewModel => Application.Locator.Second;

        private ObservableTableViewController<RestaurantItemModel> tableViewController;

        public SecondViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonDialog.SetCommand(nameof(buttonDialog.TouchUpInside), ViewModel.CommandDialog);
            buttonDownloadJson.SetCommand(nameof(buttonDownloadJson.TouchUpInside), ViewModel.CommandJson);
            bindings.Add(this.SetBinding(() => ViewModel.DialogResponse, () => labelDialogResponse.Text));

            tableViewRestaurants.RowHeight = UITableView.AutomaticDimension;
            tableViewRestaurants.EstimatedRowHeight = 100;

            tableViewController = ViewModel.Restaurants.GetController(CreateRestaurnatCell, BindRestaurantCell);
            tableViewController.TableView = tableViewRestaurants;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void BindRestaurantCell(UITableViewCell cell, RestaurantItemModel restaurant, NSIndexPath path) {
            var c = cell as RestaurantCell;
            c.Set(restaurant);
            //cell.TextLabel.Text = restaurant.Name;
            //cell.DetailTextLabel.Text = restaurant.Url;
        }

        private UITableViewCell CreateRestaurnatCell(NSString cellIdentifier) {
            var cell = tableViewRestaurants.DequeueReusableCell(nameof(RestaurantCell));

            return cell;
        }
    }
}