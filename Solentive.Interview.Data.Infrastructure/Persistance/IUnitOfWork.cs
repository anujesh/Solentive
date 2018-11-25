using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;

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
