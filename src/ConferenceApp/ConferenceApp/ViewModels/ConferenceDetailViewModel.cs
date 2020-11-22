using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceApp.ViewModels
{
    public class ConferenceDetailViewModel : BaseViewModel
    {      
        public ConferenceDetailViewModel()
        {
            Title = "Conference Details";
        }

        private Conference _selectedConference;

        public Conference SelectedConference
        {
            get { return _selectedConference; }
            set 
            {
                _selectedConference = value;
                OnPropertyChanged();
            }
        }

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
