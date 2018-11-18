using System.Collections.Generic;
using Solentive.Interview.Model;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ISeminarService
    {
        IList<Seminar> GetSeminars();
    }
}