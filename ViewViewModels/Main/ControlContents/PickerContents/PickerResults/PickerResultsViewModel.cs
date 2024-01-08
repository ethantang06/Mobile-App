using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerResults
{
    public class PickerResultsViewModel : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public string PickerSelection { get; set; }

        public PickerResultsViewModel(string value, ImageSource image)
        {
            Title = TitlesPicker.PickerResultsTitle;
            PickerSelection = value;
            ImageSrc = image;
        }
    }
}