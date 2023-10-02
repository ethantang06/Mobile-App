using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.StackLayoutPageContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents
{
    public class StackLayoutViewModel : BaseViewModel
    {
        //Button Titles
        public String StackLayoutButtonTitle { get; set; } = TitleLayouts.ButtonStackLayout;
        public String VerticalStackButtonTitle { get; set; } = TitleLayouts.ButtonVerticalStack;
        public String HorizontalStackButtonTitle { get; set; } = TitleLayouts.ButtonHorizontalStack;
        public String AbsoluteLayoutButtonTitle { get; set; } = TitleLayouts.ButtonAbsoluteLayout;

        //Button Commands
        public ICommand OnStackLayoutPageClicked { get; set; }

        //Constructor
        public StackLayoutViewModel()
        {
            Title = TitleLayouts.StackTitle;

            //Set Commands
            OnStackLayoutPageClicked = new Command(OnStackLayoutPageClickedAsync);
        }

        //Navigation
        private async void OnStackLayoutPageClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutPageView());
        }
    }
}
