using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceApp
{
    public static class MockDbContext
    {
        public static IList<Conference> GetAllData()
        {
            var speakers = new List<Speaker>();

            for (int i = 0; i < 25; i++)
            {
                speakers.Add(new Speaker() { FirstName = Faker.Name.First(), LastName = Faker.Name.Last() });
            }


            return new List<Conference>()
            {
                new Conference(){ Name="Conference O1", Location =Faker.Country.Name(), Date = new DateTime(2020,2,29), TicketCost = 15, Speakers = speakers },
                new Conference(){ Name="Conference O2", Location =Faker.Country.Name(), Date = new DateTime(2020,2,29), TicketCost = 24, Speakers = speakers },
                new Conference(){ Name="Conference O3", Location =Faker.Country.Name(), Date = new DateTime(2020,2,29), TicketCost = 23, Speakers = speakers },
                new Conference(){ Name="Conference O4", Location =Faker.Country.Name(), Date = new DateTime(2020,3,29), TicketCost = 34, Speakers = speakers },
                new Conference(){ Name="Conference O5", Location =Faker.Country.Name(), Date = new DateTime(2020,4,29), TicketCost = 34, Speakers = speakers },
                new Conference(){ Name="Conference O6", Location =Faker.Country.Name(), Date = new DateTime(2020,4,29), TicketCost = 67, Speakers = speakers },
                new Conference(){ Name="Conference O7", Location =Faker.Country.Name(), Date = new DateTime(2020,5,29), TicketCost = 11, Speakers = speakers },
                new Conference(){ Name="Conference O8", Location =Faker.Country.Name(), Date = new DateTime(2020,6,29), TicketCost = 13, Speakers = speakers },
                new Conference(){ Name="Conference O9", Location =Faker.Country.Name(), Date = new DateTime(2020,3,29), TicketCost = 56, Speakers = speakers },
                new Conference(){ Name="Conference OA", Location =Faker.Country.Name(), Date = new DateTime(2020,4,29), TicketCost = 12, Speakers = speakers },
                new Conference(){ Name="Conference OB", Location =Faker.Country.Name(), Date = new DateTime(2020,5,29), TicketCost = 34, Speakers = speakers },
                new Conference(){ Name="Conference OC", Location =Faker.Country.Name(), Date = new DateTime(2020,6,29), TicketCost = 99, Speakers = speakers },
                new Conference(){ Name="Conference OD", Location =Faker.Country.Name(), Date = new DateTime(2020,6,29), TicketCost = 15, Speakers = speakers },
                new Conference(){ Name="Conference OE", Location =Faker.Country.Name(), Date = new DateTime(2020,5,29), TicketCost = 23, Speakers = speakers },
                new Conference(){ Name="Conference OF", Location =Faker.Country.Name(), Date = new DateTime(2020,7,29), TicketCost = 13, Speakers = speakers },
                new Conference(){ Name="Conference OG", Location =Faker.Country.Name(), Date = new DateTime(2020,7,29), TicketCost = 89, Speakers = speakers },
                new Conference(){ Name="Conference OH", Location =Faker.Country.Name(), Date = new DateTime(2020,1,29), TicketCost = 12, Speakers = speakers },
            };
        }
    }
}
