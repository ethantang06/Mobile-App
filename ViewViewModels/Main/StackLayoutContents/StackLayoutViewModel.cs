using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.FlexLayoutContents;
using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.AbsoluteLayoutContents;
using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.HorizontalLayoutContents;
using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.StackLayoutPageContents;
using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.VerticalLayoutContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents
{
    public class StackLayoutViewModel : BaseViewModel
    {
        //Button Titles
        public String StackLayoutButtonTitle { get; set; } = TitleLayouts.ButtonStackLayout;
        public String VerticalStackButtonTitle { get; set; } = TitleLayouts.ButtonVerticalStack;
        public String HorizontalStackButtonTitle { get; set; } = TitleLayouts.ButtonHorizontalStack;
        public String AbsoluteLayoutButtonTitle { get; set; } = TitleLayouts.ButtonAbsoluteLayout;
        public String FlexLayoutButtonTitle { get; set; } = TitleLayouts.ButtonFlexLayout;

        //Button Commands
        public ICommand OnStackLayoutPageClicked { get; set; }
        public ICommand OnVerticalLayoutClicked { get; set; }
        public ICommand OnHorizontalLayoutClicked { get; set; }
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public ICommand OnFlexLayoutClicked { get; set; }

        //Constructor
        public StackLayoutViewModel()
        {
            Title = TitleLayouts.StackTitle;

            //Set Commands
            OnStackLayoutPageClicked = new Command(OnStackLayoutPageClickedAsync);

            OnVerticalLayoutClicked = new Command(OnVerticalLayoutClickedAsync);

            OnHorizontalLayoutClicked = new Command(OnHorizontalLayoutClickedAsync);

            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);

            OnFlexLayoutClicked = new Command(OnFlexLayoutClickedAsync);
        }

        //Navigation
        private async void OnStackLayoutPageClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutPageView());
        }
        private async void OnVerticalLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VerticalLayoutView());
        }
        private async void OnHorizontalLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new HorizontalLayoutView());
        }
        private async void OnAbsoluteLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
        private async void OnFlexLayoutClickedAsync()
        { 
            await Application.Current.MainPage.Navigation.PushAsync(new FlexLayoutView());
        }
    }
}
