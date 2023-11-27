using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class EntityCollectionPage
    {
        public string NameofGame { get; set; }

        public EntityCollectionPage()
        {
            //Constructor
        }

        public EntityCollectionPage(string name)
        {
            NameofGame = name;
        }

        public static List<EntityCollectionPage> GetGames()
        {
            return new List<EntityCollectionPage>
            {
                new EntityCollectionPage("Board Games"),
                new EntityCollectionPage("Strategy Games"),
                new EntityCollectionPage("Puzzle Games"),
                new EntityCollectionPage("Simulation Games"),
                new EntityCollectionPage("Adventure Games"),
                new EntityCollectionPage("Sports Games"),
                new EntityCollectionPage("Racing Games"),
                new EntityCollectionPage("Role-Playing Games"),
            };
        }
    }
}
