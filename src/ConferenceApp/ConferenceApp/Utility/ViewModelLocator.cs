using ConferenceApp.ViewModels;

namespace ConferenceApp.Utility
{
    public static class ViewModelLocator
    {
        public static ConferenceOverviewViewModel ConferenceOverviewViewModel
            = new ConferenceOverviewViewModel(App.ConferenceService);
    }
}
