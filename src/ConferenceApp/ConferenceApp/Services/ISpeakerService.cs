using ConferenceApp.Models;
using System.Collections.Generic;

namespace ConferenceApp.Services
{
    public interface ISpeakerService
    {
        IList<Speaker> GetAll();
    }
}