using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solentive.Interview.Data;
using System.Data.Entity;
using Solentive.Interview.Service.Interfaces;

namespace Solentive.Interview.Service
{
    public class LocationService : ILocationService
    {
        private SeminarDbContext _dbContext = null;

        public LocationService()
        {
            _dbContext = new SeminarDbContext();
        }

        public IList<Location> GetLocations()
        {
            return _dbContext.Locations.ToList();
        }

        public bool AddLocation(Location location)
        {
            _dbContext.Locations.Add(location);
            return (_dbContext.SaveChanges() > 0);
        }
    }
}
