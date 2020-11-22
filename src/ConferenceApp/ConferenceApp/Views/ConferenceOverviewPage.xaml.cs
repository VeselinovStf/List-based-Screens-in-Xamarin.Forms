using ConferenceApp.Utility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public void AddToFavoriteMessage(object sender, EventArgs e)
        {
            DisplayAlert("Added To Facorite", "Conference is added to your favorites", "Ok");
        }

        private void OnRefreshing(object sender, EventArgs e)
        {
            //Run Command in ViewModel or something else ->dont forget to EndRefresh();
        }
    }
}