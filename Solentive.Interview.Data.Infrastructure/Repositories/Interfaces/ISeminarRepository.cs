using Solentive.Interview.Model;
using System.Collections.Generic;

namespace Solentive.Interview.Data.Infrastructure.Repositories.Interfaces
{
    public interface ISeminarRepository : IRepository<Seminar>
    {
        IEnumerable<Seminar> GetSeminars();
    }
}
