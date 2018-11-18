using System.Collections.Generic;
using Solentive.Interview.Model;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ILocationService
    {
        IList<Location> GetLocations();
        bool AddLocation(Location location);
    }
}