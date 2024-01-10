using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerVM;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.PickerContents.PickerXAML;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.PickerContents
{
    public class PickerViewModel : BaseViewModel
    {
        public ICommand OnXAMLClicked { get; set; }
        public ICommand OnVMClicked { get; set; }


        public PickerViewModel()
        {
            Title = TitlePicker.PickerTitle;

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);

        }

        private async void OnXAMLClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXAMLView());
        }
        private async void OnVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());
        }
    }
}