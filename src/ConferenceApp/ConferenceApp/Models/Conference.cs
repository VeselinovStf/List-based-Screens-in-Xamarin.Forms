using System;
using System.Collections.Generic;

namespace ConferenceApp.Models
{
    public class Conference
    {
        public Conference()
        {
            Speakers = new List<Speaker>();
        }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public decimal TicketCost { get; set; }

        public IList<Speaker> Speakers { get; set; }
    }
}
