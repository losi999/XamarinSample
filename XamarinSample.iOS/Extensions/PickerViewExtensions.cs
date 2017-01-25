using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UIKit;

namespace XamarinSample.iOS.Extensions {
    public static class PickerViewExtensions {

        private class UIPickerViewBindingModel<T> : UIPickerViewModel {
            private ObservableCollection<T> items;
            private Action<int> ItemSelected;

            public UIPickerViewBindingModel(ObservableCollection<T> items, Action<int> itemSelected) {
                this.items = items;
                ItemSelected += itemSelected;
            }


            public override nint GetComponentCount(UIPickerView pickerView) {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component) {
                return items.Count;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component) {
                return items[(int)row].ToString();
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component) {
                ItemSelected((int)row);
            }
        }

        public static UIPickerViewModel GetModel<T>(this ObservableCollection<T> items, Action<int> selectionChangedDelegate) {
            var ret = new UIPickerViewBindingModel<T>(items, selectionChangedDelegate);
            return ret;
        }
    }
}
