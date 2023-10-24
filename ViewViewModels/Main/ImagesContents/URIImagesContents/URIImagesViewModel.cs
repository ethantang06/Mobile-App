using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Main.ImagesContents.URIImagesContents
{
    public class URIImagesViewModel : BaseViewModel
    {
        public String AarnavImageURL { get; } = "https://media.licdn.com/dms/image/D5603AQFn2XLDYvY00g/profile-displayphoto-shrink_800_800/0/1677816192275?e=2147483647&v=beta&t=bpN2IDz4l3Y7RcdSGRfMEKkPYvij6uZr6PxXasp0FNg";

        private ImageSource _getImageSource;

        public ImageSource GetImageSource
        {
            get
            {
                if (_getImageSource == null)
                {
                    _getImageSource = GetImage();
                }
                return _getImageSource;
            }
        }

        private ImageSource GetImage()
        {
            var imgsrc = new UriImageSource { Uri = new Uri(AarnavImageURL) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }

        public URIImagesViewModel()
        {
            Title = TitleURIImages.URIImagesTitle;
        }
    }
}
