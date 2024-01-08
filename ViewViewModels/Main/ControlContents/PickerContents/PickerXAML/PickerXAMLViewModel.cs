using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerXAML
{
    public class PickerXAMLViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/submit.png";
        public ICommand OnSubmitClicked { get; }

        private string _selectedBoard = string.Empty;

        public PickerXAMLViewModel()
        {
            Title = TitlesPicker.PickerXAMLTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedBoard
        {
            get
            {
                return _selectedBoard;
            }

            set
            {
                if (_selectedBoard != value)
                {
                    SetProperty(ref _selectedBoard, value);
                }

            }
        }

        private async void OnSubmitClickedAsync(Object obj)
        {

            List<EntityCollectionWImages> chars = EntityCollectionWImages.GetSampleBoardGameData();

            var result = chars.FirstOrDefault(x => x.BrandName.Equals(_selectedBoard));

            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(result.BoardGame, result.BoardImage));

            if (String.IsNullOrEmpty(_selectedBoard))
            {
                await Application.Current.MainPage.DisplayAlert(TitlesPicker.PickerXAMLTitle, "A selection must be made!", "OK");
                return;
            }
        }
    }
}