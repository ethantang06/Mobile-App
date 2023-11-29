using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionWButtonsContents
{
    public class CollectionWButtonsViewModel : BaseViewModel
    {
        public ObservableCollection<EntityCollectionPage> GameCollection { get; set; }

        public CollectionWButtonsViewModel()
        {
            //Set the title for this view
            Title = TitleCollectionsWButtons.MainTitle;

            //Create a new ObservableCollection to store games
            GameCollection = new ObservableCollection<EntityCollectionPage>();

            //Load games from the data source
            LoadGames();
        }

        //Method to load games from a data source
        private void LoadGames()
        {
            IsBusy = true;

            try
            {
                //Clear the existing collection
                GameCollection.Clear();

                //Get a list of games and add them to the collection
                var gameTypes = EntityCollectionPage.GetGames();
                foreach (var game in gameTypes)
                {
                    GameCollection.Add(game);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

#pragma warning disable CA1416 // Validate platform compatibility
        //Command to add a new game
        public ICommand AddCommand => new Command(async () =>
        {
            //Navigate to the AddCollectionView when the "Add" button is clicked

            await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you add a game in AddCollectionView, it sends an "AddGame" event.
            // CollectionWButtonsViewModel listens for this event and updates the game list.
            //****************************************************************************************
            //Subscribe to the "AddGame" messaging event to receive updated data from AddCollectionView            
            MessagingCenter.Subscribe<EntityCollectionPage>(this, "AddGame", async (data) =>
            {
                //Add the new game data to the collection
                GameCollection.Add(data);

                //Unsubscribe from the messaging event
                MessagingCenter.Unsubscribe<EntityCollectionPage>(this, "AddGame");
            });
        });

        //Command to update a game
        public ICommand UpdateCommand => new Command<EntityCollectionPage>(async game =>
        {
            //Get the index of the selected game in the collection
            var index = GameCollection.IndexOf(game);

            //Navigate to the EditCollectionView to edit the selected game when the Update Button is Clicked
            await Application.Current.MainPage.Navigation.PushAsync(new EditCollectionView(game));

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you update a game in EditCollectionView, it sends an "UpdateGame" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the game list.
            //****************************************************************************************
            //Subscribe to the "UpdateGame" messaging event to receive updated data from EditCollectionView            
            MessagingCenter.Subscribe<EntityCollectionPage>(this, "UpdateGame", updatedGame =>
            {
                //Update the game in the collection with the edited data
                GameCollection[index] = updatedGame;
            });
        });

        //Command to delete a game
        public ICommand DeleteCommand => new Command<EntityCollectionPage>(game =>
        {
            //Remove the selected game from the collection
            GameCollection.Remove(game);
        });
#pragma warning restore CA1416 // Validate platform compatibility

    }
}
