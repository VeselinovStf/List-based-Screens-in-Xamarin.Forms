using ConferenceApp.Models;
using ConferenceApp.Services;
using System.Collections.ObjectModel;

namespace ConferenceApp.ViewModels
{
    public class ConferenceOverviewViewModel : BaseViewModel
    {
        private readonly IConferenceService _conferenceService;
        private ObservableCollection<Conference> _conferences;

        public ConferenceOverviewViewModel(IConferenceService conferenceService)
        {
            Title = "Conference Overview";
            _conferenceService = conferenceService;

            Conferences = new ObservableCollection<Conference>();

            Initialize();
        }

        public void Initialize()
        {
            var conferencesServiceCall = _conferenceService.GetAll();

            Conferences = new ObservableCollection<Conference>(conferencesServiceCall);
        }

       
        public ObservableCollection<Conference> Conferences
        {
            get { return _conferences; }
            set { _conferences = value; }
        }


    }
}
