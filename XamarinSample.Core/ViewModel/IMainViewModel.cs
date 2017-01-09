using GalaSoft.MvvmLight.Command;

namespace XamarinSample.Core.ViewModel {
    public interface IMainViewModel : IViewModelBase {
        RelayCommand CommandClick { get; }
        RelayCommand CommandSecondPage { get; }
        int Count { get; set; }
    }
}