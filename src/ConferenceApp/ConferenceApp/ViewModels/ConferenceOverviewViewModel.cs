using ConferenceApp.Services;

namespace ConferenceApp.ViewModels
{
    public class ConferenceOverviewViewModel : BaseViewModel
    {
        private readonly IConferenceService _conferenceService;

        public ConferenceOverviewViewModel(IConferenceService conferenceService)
        {
            Title = "Conference Overview";
            _conferenceService = conferenceService;

        }

        public void Initialize()
        {

        }

       

    }
}
