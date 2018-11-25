using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using Solentive.Interview.Model;
using System.Collections.Generic;

namespace Solentive.Interview.Data.Infrastructure.Repositories
{
    public class TrackRepository : Repository<Track>, ITrackRepository
    {
        public TrackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
      
        public IEnumerable<Track> GetTracks()
        {
            return DbContext.Tracks;
        }
    }
}
