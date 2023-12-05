using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents;
using MyFirstMobileApp.ViewViewModels.Main.ImagesContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents
{
    public class MainViewModel : BaseViewModel
    {
        //Button Title
        public String StackLayoutButtonTitle { get; set; } = TitleMain.ButtonStackLayout;

        public String ImagesButtonTitle { get; set; } = TitleMain.ButtonImages;

        public String CollectionsButtonTitle { get; set; } = TitleMain.ButtonCollection;

        public String ControlButtonTitle { get; set; } = TitleMain.ButtonControl;


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

        public ICommand OnImagesClicked { get; set; }
        public ICommand OnCollectionsClicked { get; set; }
        public ICommand OnControlClicked { get; set; }

        //Constructor
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            //Set Commands
            OnLayoutsClicked = new Command(OnStackLayoutClickedAsync);
            OnImagesClicked = new Command(OnImagesClickedAsync);
            OnCollectionsClicked = new Command(OnCollectionsClickedAsync);
            OnControlClicked = new Command(OnControlClickedAsync);
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
        private async void OnCollectionsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionsView());
        }
        private async void OnControlClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlView());
        }
    }
}
