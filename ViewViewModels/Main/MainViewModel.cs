using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents;
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


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

        public ICommand OnImagesClicked { get; set; }
        public ICommand OnCollectionsClicked { get; set; }

        //Constructor
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            //Set Commands
            OnLayoutsClicked = new Command(OnStackLayoutClickedAsync);
            OnImagesClicked = new Command(OnImagesClickedAsync);
            OnCollectionsClicked = new Command(OnCollectionsClickedAsync);
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
    }
}
