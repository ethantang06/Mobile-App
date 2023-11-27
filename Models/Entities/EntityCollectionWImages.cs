using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class EntityCollectionWImages
    {
        //Properties - Initialized to an Empty String
        public string BoardGame { get; set; } = string.Empty;
        public ImageSource BoardImage { get; set; } = null;
        public string BrandName { get; set; } = string.Empty;

        public EntityCollectionWImages()
        {
            //Constructor
        }

        public EntityCollectionWImages(string boardGame, ImageSource boardImage, string brandName)
        {
            //Constructor with Parameters
            BoardGame = boardGame;
            BoardImage = boardImage;
            BrandName = brandName;
        }

        public static List<EntityCollectionWImages> GetSampleBoardGameData()
        {
            var boardgames = new List<EntityCollectionWImages>
            {
                //Create EntityCollectionWImages objects with sample data
                new EntityCollectionWImages("Monopoly",ImageSource.FromFile("Images/BoardGames/monopoly.jpg"), "Hasbro"),
                new EntityCollectionWImages("Sorry!",ImageSource.FromFile("Images/BoardGames/sorry.jpg"), "Hasbro"),
                new EntityCollectionWImages("The Game of Life",ImageSource.FromFile("Images/BoardGames/life.jpg"), "Hasbro"),
                new EntityCollectionWImages("Checkers",ImageSource.FromFile("Images/BoardGames/checkers.jpg"), "WS Game Company"),
                new EntityCollectionWImages("Catan",ImageSource.FromFile("Images/BoardGames/catan.jpg"), "Klaus Teuber"),
            };

            return boardgames;
        }

        public static List<string> GetBoardGameName()
        {
            //Get the sample boardgame data
            var sampleData = GetSampleBoardGameData();

            //Select and convert boardgame names to a list
            return sampleData.Select(info => info.BrandName).ToList();
        }
    }
}
