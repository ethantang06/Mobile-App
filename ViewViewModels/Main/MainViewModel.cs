using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.StackLayoutContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        //Button Title
        public String StackLayoutButtonTitle { get; set; } = TitleMain.ButtonStackLayout;

        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

         //Constructor
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            //Set Commands
            OnLayoutsClicked = new Command(OnStackLayoutClickedAsync);
        }

        //Navigation
        private async void OnStackLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }
    }
}
