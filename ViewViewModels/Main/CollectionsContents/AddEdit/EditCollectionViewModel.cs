using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit
{
    public class EditCollectionViewModel : BaseViewModel
    {
        public ICommand UpdateBtnClicked { get; set; }
        private string _gameName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitlesMisc.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string GameName
        {
            get { return _gameName; }

            set
            {
                if (_gameName != value)
                    // Use the SetProperty method to update the private field _games
                    // and trigger property change notifications when the Games property value changes.
                    SetProperty(ref _gameName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_gameName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            EntityCollectionPage games = new EntityCollectionPage();
            games.NameofGame = _gameName;

            MessagingCenter.Send<EntityCollectionPage>(games, "UpdateGame");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
