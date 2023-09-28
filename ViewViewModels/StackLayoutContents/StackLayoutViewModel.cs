using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents
{
    public class StackLayoutViewModel : BaseViewModel
    {
        //Button Titles
        public String StackLayoutButtonTitle { get; set; } = TitleLayouts.ButtonStackLayout;
        public String VerticalStackButtonTitle { get; set; } = TitleLayouts.ButtonVerticalStack;
        public String HorizontalStackButtonTitle { get; set; } = TitleLayouts.ButtonHorizontalStack;
        public String AbsoluteLayoutButtonTitle { get; set; } = TitleLayouts.ButtonAbsoluteLayout;

        //Constructor
        public StackLayoutViewModel()
        {
            Title = TitleLayouts.StackTitle;
        }
    }
}
