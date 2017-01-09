using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Android.Activities;
using XamarinSample.ViewModel;
using GalaSoft.MvvmLight.Helpers;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : ActivityBase<ISecondViewModel> {
        protected override ISecondViewModel ViewModel => App.Locator.Second;

        public Button buttonDialog => FindViewById<Button>(Resource.Id.buttonDialog);
        public Button buttonDownloadJson => FindViewById<Button>(Resource.Id.buttonDownloadJson);
        public TextView textViewDialogResponse => FindViewById<TextView>(Resource.Id.textViewDialogResponse);
        public ListView listViewRestaurants => FindViewById<ListView>(Resource.Id.listViewRestaurants);

        public ObservableAdapter<RestaurantItemModel> RestaurantsAdapter { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Second);

            bindings.Add(this.SetBinding(() => ViewModel.DialogResponse, () => textViewDialogResponse.Text));

            buttonDialog.SetCommand(ViewModel.CommandDialog);
            buttonDownloadJson.SetCommand(ViewModel.CommandJson);

            RestaurantsAdapter = ViewModel.Restaurants.GetAdapter(GetRestaurantsAdapter);
            listViewRestaurants.Adapter = RestaurantsAdapter;

        }


        private View GetRestaurantsAdapter(int position, RestaurantItemModel restaurant, View view) {

            view = LayoutInflater.Inflate(Resource.Layout.RestaurantRow, null);

            view.FindViewById<TextView>(Resource.Id.textViewRestaurantId).Text = restaurant.Id.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewRestaurantName).Text = restaurant.Name.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewRestaurantUrl).Text = restaurant.Url.ToString();

            return view;
        }
    }
}