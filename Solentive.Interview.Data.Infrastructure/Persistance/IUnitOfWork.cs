using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data.Infrastructure.Persistance
{
    public interface IUnitOfWork 
    {
        ILevelRepository Levels { get; }
        ILocationRepository Locations { get; }
        ITrackRepository Tracks { get; }
        ISeminarRepository Seminars { get; }
        int Save();
    }
}
