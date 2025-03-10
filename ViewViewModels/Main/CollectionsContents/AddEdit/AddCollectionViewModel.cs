﻿using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit
{
    public class AddCollectionViewModel : BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _gameName = string.Empty;

        public AddCollectionViewModel()
        {
            Title = TitlesMisc.AddTitle;
            SaveBtnClicked = new Command(PerformSave);
        }

        public string GameName
        {
            get { return _gameName; }

            set
            {
                if (_gameName != value)
                    SetProperty(ref _gameName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_gameName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            EntityCollectionPage games = new EntityCollectionPage();
            games.NameofGame = _gameName;

            MessagingCenter.Send<EntityCollectionPage>(games, "AddGame");

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.Navigation.PopAsync();
            }
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
