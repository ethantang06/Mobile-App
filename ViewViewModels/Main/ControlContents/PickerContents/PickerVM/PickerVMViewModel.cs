using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerResults;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerVM
{
    public class PickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/submit.png";

        //Property to bind the Picker Item Source
        public List<string> BoardList { get; set; }
        List<EntityCollectionWImages> _boardgames;
        string _selectedBoard= string.Empty;

        public ICommand OnSubmitClicked { get; }

        public PickerVMViewModel()
        {
            //Set Title
            Title = TitlesPicker.PickerVMTitle;

            //Get BoardGames from EntityCollectionWImages Class to Populate Picker
            this.GetBoardList();

            //Set Submit Button Command
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private void GetBoardList()
        {
            var allBoardInfo = EntityCollectionWImages.GetSampleBoardGameData();

            //Filter and map the boardgame names from the list of EntityCollectionWImages objects
            BoardList = allBoardInfo.Select(info => info.BrandName).ToList();
            _boardgames = allBoardInfo;
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

        private async void OnSubmitClickedAsync(object obj)
        {
            //Verify user made a selection
            if (string.IsNullOrEmpty(_selectedBoard))
            {
                await Application.Current.MainPage.DisplayAlert(TitlesPicker.PickerVMTitle, "A selection must be made!", "OK");
                return;
            }

            //Get selection
            var selectedBoardName = _selectedBoard;

            //Find the EntityCollectionWImages based on the selected boardgame name
            var selectedBoardInfo = _boardgames.FirstOrDefault(info => info.BrandName == selectedBoardName);

            if (selectedBoardInfo != null)
            {
                //Combining game's name and brand's name into a single string for display
                string name = $"{selectedBoardInfo.BoardGame} As {selectedBoardInfo.BrandName}";

                //Use selected BoardInfo.BoardImage for the games's image
                await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(name, selectedBoardInfo.BoardImage));
            }
        }
    }
}