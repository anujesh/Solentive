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
    public class LevelService : ILevelService
    {
        private SeminarDbContext _dbContext = null;

        public LevelService()
        {
            _dbContext = new SeminarDbContext();
        }

        public IList<Level> GetLevels()
        {
            return _dbContext.Levels.ToList();
        }

        public bool AddLevel(Level level)
        {
            _dbContext.Levels.Add(level);
            return (_dbContext.SaveChanges() > 0);
        }
    }
}
