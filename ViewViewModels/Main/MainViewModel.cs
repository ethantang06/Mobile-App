using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.StackLayoutContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public String StackLayoutButtonTitle { get; set; } = TitleMain.ButtonStackLayout;

        public ICommand OnLayoutClicked { get; set; }
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            OnLayoutClicked = new Command(OnStackLayoutClickedAsync);
        }

        private async void OnStackLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }
    }
}
