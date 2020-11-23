using ConferenceApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSpeakerPage : ContentPage
    {
        public AddSpeakerPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.AddSpeakerViewModel;
        }
    }
}