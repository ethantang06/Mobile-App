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

namespace MyFirstMobileApp.ViewViewModels.Main.CollectionsContents.CollectionWImagesContents
{
    public class CollectionWImagesViewModel : BaseViewModel
    {
        public ObservableCollection<EntityCollectionWImages> BoardGamesCollection { get; }

        private List<EntityCollectionWImages> _boardgames;
        public CollectionWImagesViewModel()
        {
            Title = TitleCollectionImages.CollectionImagesTitle;

            //Instantiate Observable BoardGamesCollection
            BoardGamesCollection = new ObservableCollection<EntityCollectionWImages>();
            _boardgames = EntityCollectionWImages.GetSampleBoardGameData();
            this.LoadBoardGames();
        }

        private void LoadBoardGames()
        {
            try
            {
                BoardGamesCollection.Clear();
                foreach (var b in _boardgames)
                {
                    BoardGamesCollection.Add(b);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
