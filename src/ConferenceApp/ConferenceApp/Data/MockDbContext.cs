using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceApp.Data
{
    public static class MockDbContext
    {
        public static IList<Conference> GetAllConferences()
        {
            return new List<Conference>()
            {
                new Conference(){ Name="Conference O1", Location ="Bulgaria", Date = new DateTime(2020,2,29) },
                new Conference(){ Name="Conference O2", Location ="US", Date = new DateTime(2020,2,29) },
                new Conference(){ Name="Conference O3", Location ="Romania", Date = new DateTime(2020,2,29) },
                new Conference(){ Name="Conference O4", Location ="Bulgaria", Date = new DateTime(2020,3,29) },
                new Conference(){ Name="Conference O5", Location ="Bulgaria", Date = new DateTime(2020,4,29) },
                new Conference(){ Name="Conference O6", Location ="US", Date = new DateTime(2020,4,29) },
                new Conference(){ Name="Conference O7", Location ="Bulgaria", Date = new DateTime(2020,5,29) },
                new Conference(){ Name="Conference O8", Location ="Bulgaria", Date = new DateTime(2020,6,29) },
                new Conference(){ Name="Conference O9", Location ="US", Date = new DateTime(2020,3,29) },
                new Conference(){ Name="Conference OA", Location ="Bulgaria", Date = new DateTime(2020,4,29) },
                new Conference(){ Name="Conference OB", Location ="Bulgaria", Date = new DateTime(2020,5,29) },
                new Conference(){ Name="Conference OC", Location ="US", Date = new DateTime(2020,6,29) },
                new Conference(){ Name="Conference OD", Location ="England", Date = new DateTime(2020,6,29) },
                new Conference(){ Name="Conference OE", Location ="Bulgaria", Date = new DateTime(2020,5,29) },
                new Conference(){ Name="Conference OF", Location ="England", Date = new DateTime(2020,7,29) },
                new Conference(){ Name="Conference OG", Location ="Romania", Date = new DateTime(2020,7,29) },
                new Conference(){ Name="Conference OH", Location ="Bulgaria", Date = new DateTime(2020,1,29) },
            };
        }

        public static IList<Speaker> GetAllSpeakers()
        {
            var speakers = new List<Speaker>();

            for (int i = 0; i < 25; i++)
            {
                speakers.Add(new Speaker() { FirstName = "First Name" + i, LastName = "Last Name" + i, Image = "placeholder.png" });
                }

            return speakers;
        }
    }
}
