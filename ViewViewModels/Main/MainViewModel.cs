using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main;
using MyFirstMobileApp.ViewViewModels.Main.ImagesContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents
{
    public class MainViewModel : BaseViewModel
    {
        //Button Title
        public String StackLayoutButtonTitle { get; set; } = TitleMain.ButtonStackLayout;

        public String ImagesButtonTitle { get; set; } = TitleMain.ButtonImages;


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

        public ICommand OnImagesClicked { get; set; }

        //Constructor
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            //Set Commands
            OnLayoutsClicked = new Command(OnStackLayoutClickedAsync);
            OnImagesClicked = new Command(OnImagesClickedAsync);
        }

        //Navigation
        private async void OnStackLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }
        private async void OnImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImagesView());
        }
    }
}
