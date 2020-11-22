using System;

namespace ConferenceApp.Models
{
    public class Conference
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public decimal TicketCost { get; set; }
    }
}
