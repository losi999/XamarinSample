using GalaSoft.MvvmLight.Command;

namespace XamarinSample.Core.ViewModel {
    public interface IMainViewModel : IViewModelBase {
        RelayCommand CommandDialogsPage { get; }
        RelayCommand CommandSettingsPage { get; }
        RelayCommand CommandPersonsPage { get; }
        RelayCommand CommandMapPage { get; }
        RelayCommand CommandLoginPage { get; }
    }
}