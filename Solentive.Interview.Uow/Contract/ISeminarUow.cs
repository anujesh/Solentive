using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Uow.Contract
{
    public interface ISeminarUow : IDisposable
    {
        bool Commit();
        IRepository<Location> Locations { get; }
        IRepository<Track> Tracks { get; }
        IRepository<Level> Levels { get; }
        IRepository<Seminar> Seminars { get; }
    }
}
