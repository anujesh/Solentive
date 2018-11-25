using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using Solentive.Interview.Model;
using System.Collections.Generic;

namespace Solentive.Interview.Data.Infrastructure.Repositories
{
    public class SeminarRepository : Repository<Seminar>, ISeminarRepository
    {
        public SeminarRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }       
        public IEnumerable<Seminar> GetSeminars()
        {
            return DbContext.Seminars.Include("Location").Include("Level").Include("Track");
        }
    }
}
