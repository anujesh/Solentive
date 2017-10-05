using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solentive.Interview.Data;

namespace Solentive.Interview.Service
{
    public class TrackService
    {
        private SeminarDbContext _dbContext = null;

        public TrackService ()
	    {
            _dbContext = new SeminarDbContext();
        }

        public IList<Track> GetTracks()
        {
            return _dbContext.Tracks.ToList();
        }

        public bool AddTrack(Track track)
        {
            _dbContext.Tracks.Add(track);
            return (_dbContext.SaveChanges() > 0);
        }
    }
}
