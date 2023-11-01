using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionWButtonsContents;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionWImagesContents;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionWIconsContents;

namespace MyFirstMobileApp.ViewViewModels.Main.CollectionsContents
{
    public class CollectionsViewModel : BaseViewModel
    {
        //Button Titles
        public String CollectionButtonTitle { get; set; } = TitleCollections.ButtonCollectionButton;
        public String CollectionWImagesButtonTitle { get; set; } = TitleCollections.ButtonCollectionImages;
        public String CollectionWButtonsButtonTitle { get; set; } = TitleCollections.ButtonCollection;
        public String CollectionWIconsButtonTitle { get; set; } = TitleCollections.ButtonCollectionIcons;

        //Button Commands
        public ICommand OnCollectionClicked { get; set; }
        public ICommand OnCollectionWImagesClicked { get; set; }
        public ICommand OnCollectionWButtonsClicked { get; set; }
        public ICommand OnCollectionWIconsClicked { get; set; }

        //Constructor
        public CollectionsViewModel()
        {
            Title = TitleCollections.CollectionsTitle;

            //Set Commands
            OnCollectionClicked = new Command(OnCollectionClickedAsync);
            OnCollectionWImagesClicked = new Command(OnCollectionWImagesClickedAsync);
            OnCollectionWButtonsClicked = new Command(OnCollectionWButtonsClickedAsync);
            OnCollectionWIconsClicked = new Command(OnCollectionWIconsClickedAsync);
        }

        //Navigation
        private async void OnCollectionClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionPageView());
        }
        private async void OnCollectionWImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionWImagesView());
        }
        private async void OnCollectionWButtonsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionWButtonsView());
        }
        private async void OnCollectionWIconsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionWIconsView());
        }
    }
}
