using ConferenceApp.Services;
using ConferenceApp.Views;
using Xamarin.Forms;

namespace ConferenceApp
{
    public partial class App : Application
    {
        public static ConferenceService ConferenceService
            = new ConferenceService();

        public App()
        {
            InitializeComponent();

            MainPage = new ConferenceOverviewPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
