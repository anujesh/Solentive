using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using Solentive.Interview.Model;
using System.Collections.Generic;

namespace Solentive.Interview.Data.Infrastructure.Repositories
{

    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
      
        public IEnumerable<Location> GetLocations()
        {
            return DbContext.Locations;
        }
    }
}
