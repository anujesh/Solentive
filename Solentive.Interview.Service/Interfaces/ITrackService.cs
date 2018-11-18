using System.Collections.Generic;
using Solentive.Interview.Model;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ITrackService
    {
        IList<Track> GetTracks();
        bool AddTrack(Track track);
    }
}