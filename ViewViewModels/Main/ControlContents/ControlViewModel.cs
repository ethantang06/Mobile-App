using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.SliderContents;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.StepperContents;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.SwitchContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents
{
    public class ControlViewModel : BaseViewModel
    {
        //Button Title
        public String SliderButtonTitle { get; set; } = TitleControl.ButtonSlider;

        public String StepperButtonTitle { get; set; } = TitleControl.ButtonStepper;

        public String SwitchButtonTitle { get; set; } = TitleControl.ButtonSwitch;


        //Button Commands
        public ICommand OnSliderClicked { get; set; }

        public ICommand OnStepperClicked { get; set; }
        public ICommand OnSwitchClicked { get; set; }

        //Constructor
        public ControlViewModel()
        {
            Title = TitleControl.ControlTitle;

            //Set Commands
            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
        }

        //Navigation
        private async void OnSliderClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
        private async void OnStepperClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }
        private async void OnSwitchClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }
    }
}
