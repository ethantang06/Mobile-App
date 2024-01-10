using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.ControlContents.DatePickerContents;
using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.EntryContents;
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

        public String EntryButtonTitle { get; set; } = TitleControl.ButtonEntry;

        public String PickerButtonTitle { get; set; } = TitleControl.ButtonPicker;
        public String DatePickerButtonTitle { get; set; } = TitleControl.ButtonDatePicker;


        //Button Commands
        public ICommand OnSliderClicked { get; set; }
        public ICommand OnStepperClicked { get; set; }
        public ICommand OnSwitchClicked { get; set; }
        public ICommand OnEntryClicked { get; set; }
        public ICommand OnPickerClicked { get; set; }
        public ICommand OnDatePickerClicked { get; set; }



        //Constructor
        public ControlViewModel()
        {
            Title = TitleControl.ControlTitle;

            //Set Commands
            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
            OnEntryClicked = new Command(OnEntryClickedAsync);
            OnPickerClicked = new Command(OnPickerClickedAsync);
            OnDatePickerClicked = new Command(OnDatePickerClickedAsync);
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
        private async void OnEntryClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryView());
        }
        private async void OnPickerClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerView());
        }
        private async void OnDatePickerClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }
    }
}
