using ConferenceApp.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConferenceOverviewPage : ContentPage
    {
        public ConferenceOverviewPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.ConferenceOverviewViewModel;
        }
    }
}