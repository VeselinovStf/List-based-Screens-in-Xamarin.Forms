using ConferenceApp.Data;
using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceApp.Services
{
    public class SpeakerService : ISpeakerService
    {
        public IList<Speaker> GetAll()
        {
            return MockDbContext.GetAllSpeakers();
        }
    }
}
