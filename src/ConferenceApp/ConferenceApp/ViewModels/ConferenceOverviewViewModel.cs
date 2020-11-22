using ConferenceApp.Extensions;
using ConferenceApp.Grouping;
using ConferenceApp.Models;
using ConferenceApp.Services;
using ConferenceApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConferenceApp.ViewModels
{
    public class ConferenceOverviewViewModel : BaseViewModel
    {
        private readonly IConferenceService _conferenceService;
        private readonly INavigationService _navigationService;
        private ObservableCollection<ConferenceModelGrouping> _conferences;

        public ConferenceOverviewViewModel(
            IConferenceService conferenceService,
            INavigationService navigationService)
        {
            Title = "Conference Overview";
            _conferenceService = conferenceService;
            _navigationService = navigationService;
            Conferences = new ObservableCollection<ConferenceModelGrouping>();
            SelectedItemCommand = new Command<Conference>(OnSelectedItem);

            Initialize();
        }

        private void OnSelectedItem(Conference conference)
        {
            _navigationService.NavigateTo(ViewModelNames.ConferenceDetailView, conference);
        }

        public ICommand SelectedItemCommand { get; }

        public void Initialize()
        {
            var conferencesServiceCall = _conferenceService.GetAll();

            var grouping = LoadListGroupingItems(conferencesServiceCall);

            Conferences = new ObservableCollection<ConferenceModelGrouping>(grouping);
        }


        private Conference _selectedItem;

        public Conference SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                {
                    return;
                }

                SelectedItemCommand.Execute(_selectedItem);

                SelectedItem = null;
            }
        }

        private ObservableCollection<ConferenceModelGrouping> LoadListGroupingItems(IList<Conference> conferencesServiceCall)
        {
            ConferenceModelGrouping janGrouping = new ConferenceModelGrouping(1); 
            ConferenceModelGrouping febGrouping = new ConferenceModelGrouping(2); 
            ConferenceModelGrouping marGrouping = new ConferenceModelGrouping(3); 
            ConferenceModelGrouping aprGrouping = new ConferenceModelGrouping(4); 
            ConferenceModelGrouping mayGrouping = new ConferenceModelGrouping(5); 
            ConferenceModelGrouping junGrouping = new ConferenceModelGrouping(6); 
            ConferenceModelGrouping jylGrouping = new ConferenceModelGrouping(7);

            var grouping = new ObservableCollection<ConferenceModelGrouping>()
            {
                janGrouping,
                febGrouping,
                marGrouping,
                aprGrouping,
                mayGrouping,
                junGrouping,
                jylGrouping,
            };

            foreach (var group in grouping)
            {            
                var monthElements = conferencesServiceCall
                    .Where(e => DateTimeExtension.IntToMonthName(e.Date.Month) == group.MonthName);

                foreach (var me in monthElements)
                {
                    group.Add(me);
                }
            }

            return grouping;
        }

        public ObservableCollection<ConferenceModelGrouping> Conferences
        {
            get { return _conferences; }
            set { _conferences = value; }
        }

        private string _footerText = "Copyrights 2020";

        public string FooterText
        {
            get { return _footerText ; }
            set { _footerText  = value; }
        }


    }
}
