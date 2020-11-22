using ConferenceApp.Models;
using System;
using System.Collections.Generic;

namespace ConferenceApp.Services
{
    public class ConferenceService : IConferenceService
    {
        public IList<Conference> GetAll()
        {
            return new List<Conference>() 
            {
                new Conference(){ Name="Conference O1", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 15 },
                new Conference(){ Name="Conference O2", Location ="Bulgaria, Plovdiv", Date = DateTime.Now, TicketCost = 24},
                new Conference(){ Name="Conference O3", Location ="Bulgaria, Varna", Date = DateTime.Now, TicketCost = 23 },
                new Conference(){ Name="Conference O4", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 34 },
                new Conference(){ Name="Conference O5", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 34 },
                new Conference(){ Name="Conference O6", Location ="Bulgaria, Plovdiv", Date = DateTime.Now, TicketCost = 67 },
                new Conference(){ Name="Conference O7", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 11 },
                new Conference(){ Name="Conference O8", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 13 },
                new Conference(){ Name="Conference O9", Location ="Bulgaria, Plovdiv", Date = DateTime.Now, TicketCost = 56 },
                new Conference(){ Name="Conference OA", Location ="Bulgaria, Varna", Date = DateTime.Now, TicketCost = 12 },
                new Conference(){ Name="Conference OB", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 34 },
                new Conference(){ Name="Conference OC", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 99 },
                new Conference(){ Name="Conference OD", Location ="Bulgaria, Plovdiv", Date = DateTime.Now, TicketCost = 15 },
                new Conference(){ Name="Conference OE", Location ="Bulgaria, Varna", Date = DateTime.Now, TicketCost = 23 },
                new Conference(){ Name="Conference OF", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 13 },
                new Conference(){ Name="Conference OG", Location ="Bulgaria, Plovdiv", Date = DateTime.Now, TicketCost = 89 },
                new Conference(){ Name="Conference OH", Location ="Bulgaria, Sofia", Date = DateTime.Now, TicketCost = 12 },
            };
        }

    }
}
