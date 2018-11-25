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
    public class LevelRepository : Repository<Level>, ILevelRepository
    {
        public LevelRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        
        public IEnumerable<Level> GetLevels()
        {
            return DbContext.Levels;
        }
    }
}
