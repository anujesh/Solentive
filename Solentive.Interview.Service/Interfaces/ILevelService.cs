using System.Collections.Generic;
using Solentive.Interview.Model;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ILevelService
    {
        IList<Level> GetLevels();
        bool AddLevel(Level level);
    }
}