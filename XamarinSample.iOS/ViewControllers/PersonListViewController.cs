using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;
using Foundation;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Model.Enum;
using XamarinSample.iOS.Converters;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonListViewController : ViewControllerBase<IPersonListViewModel> {
        private ObservableTableViewController<PersonItemModel> personsViewController;

        protected override IPersonListViewModel ViewModel => Application.Locator.PersonList;

        public PersonListViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidAppear(bool animated) {
            base.ViewDidAppear(animated);

            ViewModel.CommandLoaded.Execute(null);
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            tableViewPersons.RowHeight = UITableView.AutomaticDimension;
            tableViewPersons.EstimatedRowHeight = 100;

            personsViewController = ViewModel.Persons.GetController(GetPersonsCell, BindPersonsCell);
            personsViewController.TableView = tableViewPersons;

            //personsViewController.SetCommand("SelectionChanged", personsViewController.SelectedItem?.CommandPersonDetails, personsViewController.SelectedItem?.Id);

            //personsViewController.SelectionChanged += PersonsViewController_SelectionChanged;
        }

        private void PersonsViewController_SelectionChanged(object sender, EventArgs e) {
            System.Diagnostics.Debug.Write("selected");
        }

        private UITableViewCell GetPersonsCell(NSString id) {
            return tableViewPersons.DequeueReusableCell(nameof(PersonCell));
        }

        private void BindPersonsCell(UITableViewCell cell, PersonItemModel item, NSIndexPath index) {
            var c = cell as PersonCell;
            bindings.Add(new Binding<string, string>(item, () => item.Name, c, () => c.LabelName.Text));
            bindings.Add(new Binding<int, string>(item, () => item.Age, c, () => c.LabelAge.Text));
            bindings.Add(new Binding<Gender, string>(item, () => item.Gender, c, () => c.LabelGender.Text).ConvertSourceToTarget((gender) => {
                return gender.ToString();
            }));
            bindings.Add(new Binding<string, string>(item, () => item.Address, c, () => c.LabelAddress.Text));
            //bindings.Add(new Binding<string, bool>(item, () => item.Address, c, () => c.LabelAddress.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            bindings.Add(new Binding<string, string>(item, () => item.EMail, c, () => c.LabelEMail.Text));
            //bindings.Add(new Binding<string, bool>(item, () => item.EMail, c, () => c.LabelEMail.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            bindings.Add(new Binding<string, string>(item, () => item.PhoneNumber, c, () => c.LabelPhoneNumber.Text));
            //bindings.Add(new Binding<string, bool>(item, () => item.PhoneNumber, c, () => c.LabelPhoneNumber.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));
        }
    }
}