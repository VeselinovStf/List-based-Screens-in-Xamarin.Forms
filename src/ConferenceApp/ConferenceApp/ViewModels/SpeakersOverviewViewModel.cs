using ConferenceApp.Models;
using ConferenceApp.Services;
using System.Collections.ObjectModel;

namespace ConferenceApp.ViewModels
{
    public class SpeakersOverviewViewModel : BaseViewModel
    {
        private readonly ISpeakerService _speakerService;
        private readonly INavigationService _navigationService;

        public SpeakersOverviewViewModel(ISpeakerService speakerService, INavigationService navigationService)
        {
            Title = "Speakers";

            _speakerService = speakerService;
            _navigationService = navigationService;

            Speakers = new ObservableCollection<Speaker>();

            Initialize();
        }

        private void Initialize()
        {
            var serviceCall = _speakerService.GetAll();

            foreach (var speaker in serviceCall)
            {
                Speakers.Add(speaker);
            }
        }

        private ObservableCollection<Speaker> _speakers;

        public ObservableCollection<Speaker> Speakers
        {
            get { return _speakers; }
            set { _speakers = value; }
        }


    }
}
