using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
