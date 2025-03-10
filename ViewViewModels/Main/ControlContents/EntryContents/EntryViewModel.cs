﻿using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Main.ControlContents.EntryContents.EntryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.EntryContents
{
    public class EntryViewModel : BaseViewModel
    {
        public ICommand OnEntryButtonClicked { get; }
        public string _entryText = string.Empty;
        public EntryViewModel()
        {
            Title = TitleEntry.MyEntryPageMenuText;
            OnEntryButtonClicked = new Command(OnEntryButtonClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }

            set
            {
                if (_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }
            }
        }

        private async void OnEntryButtonClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleEntry.MyEntryPageMenuText, "Entry can't be empty!", "OK");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new EntryResultsView(_entryText));
        }
    }
}
