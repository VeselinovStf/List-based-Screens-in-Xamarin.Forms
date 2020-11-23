using ConferenceApp.ViewModels;

namespace ConferenceApp.Utility
{
    public static class ViewModelLocator
    {
        public static ConferenceOverviewViewModel ConferenceOverviewViewModel
            = new ConferenceOverviewViewModel(App.ConferenceService, App.NavigationService);

        public static ConferenceDetailViewModel ConferenceDetailViewModel
            = new ConferenceDetailViewModel(App.NavigationService);

        public static SpeakersOverviewViewModel SpeakersOverviewViewModel
                = new SpeakersOverviewViewModel(App.SpeakerService, App.NavigationService);

        public static AddSpeakerViewModel AddSpeakerViewModel
                = new AddSpeakerViewModel();
    }
}
