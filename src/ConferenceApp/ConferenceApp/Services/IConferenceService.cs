using ConferenceApp.Models;
using System.Collections.Generic;

namespace ConferenceApp.Services
{
    public interface IConferenceService
    {
        IList<Conference> GetAll();
    }
}