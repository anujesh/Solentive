using Solentive.Interview.Data.Infrastructure.Repositories;
using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data.Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SeminarDbContext _dbContext;

        public ILevelRepository Levels { get; private set; }
        public ILocationRepository Locations { get; private set; }
        public ITrackRepository Tracks { get; private set; }
        public ISeminarRepository Seminars { get; private set; }

       
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            Levels = new LevelRepository(dbFactory);
            Locations = new LocationRepository(dbFactory);
            Tracks = new TrackRepository(dbFactory);
            Seminars = new SeminarRepository(dbFactory);
        }

        public SeminarDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = dbFactory.Init()); }
        }

        public int Save()
        {
            return DbContext.Commit();
        }
    }
}
