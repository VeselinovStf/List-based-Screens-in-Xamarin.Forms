using ConferenceApp.Models;
using ConferenceApp.Services;
using ConferenceApp.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConferenceApp.ViewModels
{
    public class ConferenceDetailViewModel : BaseViewModel
    {      
        public ConferenceDetailViewModel(INavigationService navigationService)
        {
            Title = "Conference Details";

            ViewSpeakersCommand = new Command(OnViewSpeakers);
            _navigationService = navigationService;
        }

        private async void OnViewSpeakers()
        {
            _navigationService.NavigateTo(ViewModelNames.SpeakersOverviewPageView);
        }

        private Conference _selectedConference;
        private readonly INavigationService _navigationService;

        public Conference SelectedConference
        {
            get { return _selectedConference; }
            set 
            {
                _selectedConference = value;
                OnPropertyChanged();
            }
        }

        public ICommand ViewSpeakersCommand { get; }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                SelectedConference = new Conference();
            }
            else
            {
                SelectedConference = parameter as Conference;
            }
        }

    }
}
