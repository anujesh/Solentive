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
