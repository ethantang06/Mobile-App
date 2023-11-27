using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionContents
{
    public class CollectionPageViewModel : BaseViewModel
    {
        // ViewModel: Private fields
        private List<EntityCollectionPage> _games;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes
        public ObservableCollection<EntityCollectionPage> GamesCollection { get; }

        public CollectionPageViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = TitleCollection.CollectionTitle;

            // ViewModel: Initialize the ObservableCollection
            GamesCollection = new ObservableCollection<EntityCollectionPage>();

            _games = EntityCollectionPage.GetGames();
            this.LoadGames();
        }

        // ViewModel: Load ga,mes into the Observable Collection
        private void LoadGames()
        {
            try
            {
                // Clear the collection in the ViewModel
                GamesCollection.Clear();

                //Loop through all the games in the ViewModel collection
                foreach (var t in _games)
                {
                    // Add the NameofGame property of the individual game to the ViewModel collection
                    GamesCollection.Add(new EntityCollectionPage { NameofGame = t.NameofGame });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}


