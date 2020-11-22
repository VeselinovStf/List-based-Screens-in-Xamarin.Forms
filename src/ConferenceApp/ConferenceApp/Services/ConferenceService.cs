using ConferenceApp.Models;
using System.Collections.Generic;

namespace ConferenceApp.Services
{
    public class ConferenceService : IConferenceService
    {
        public IList<Conference> GetAll()
        {
            return MockDbContext.GetAllData();
        }

    }
}
