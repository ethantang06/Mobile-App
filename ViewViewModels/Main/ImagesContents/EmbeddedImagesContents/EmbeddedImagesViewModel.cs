using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Main.ImagesContents.EmbeddedImagesContents
{
    public class EmbeddedImagesViewModel : BaseViewModel
    {
        public EmbeddedImagesViewModel()
        {
            Title = TitleEmbeddedImages.EmbeddedImagesTitle;
        }

        public ImageSource GetImageSource
        {
            get
            {
                return ImageSource.FromFile("Images/michael.PNG");
            }
        }
    }
}
