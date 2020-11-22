using ConferenceApp.Extensions;
using ConferenceApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace ConferenceApp.Grouping
{
    public class ConferenceModelGrouping : ObservableCollection<Conference>
    {
        public ConferenceModelGrouping(int month)
        {
            MonthName = DateTimeExtension.IntToMonthName(month);
        }

        public string MonthName { get; }
    }
}
