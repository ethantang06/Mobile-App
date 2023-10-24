using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main.ImagesContents.EmbeddedImagesContents;
using MyFirstMobileApp.ViewViewModels.Main.ImagesContents.URIImagesContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.ImagesContents
{
    public class ImagesViewModel : BaseViewModel
    {
        //Button Titles
        public String URIButtonTitle { get; set; } = TitleImages.ButtonURIImages;
        public String EmbeddedButtonTitle { get; set; } = TitleImages.ButtonEmbeddedImages;

        //Button Commands
        public ICommand OnURIImagesClicked { get; set; }
        public ICommand OnEmbeddedImagesClicked { get; set; }

        //Constructor
        public ImagesViewModel()
        {
            Title = TitleImages.URIButtonTitle;

            //Set Commands
            OnURIImagesClicked = new Command(OnURIImagesClickedAsync);
            OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
        }

        //Navigation
        private async void OnURIImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URIImagesView());
        }
        private async void OnEmbeddedImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
        }
    }
}
