﻿using ConferenceApp.Services;
using ConferenceApp.Utility;
using ConferenceApp.ViewModels;
using ConferenceApp.Views;
using Xamarin.Forms;

namespace ConferenceApp
{
    public partial class App : Application
    {
        public static ConferenceService ConferenceService
            = new ConferenceService();

        public static NavigationService NavigationService =
             new NavigationService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewModelNames.ConferenceDetailView, typeof(ConferenceDetailPage));
            NavigationService.Configure(ViewModelNames.ConferenceOverviewView, typeof(ConferenceOverviewPage));

            MainPage = new NavigationPage(new ConferenceOverviewPage());
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
