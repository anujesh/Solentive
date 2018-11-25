using Solentive.Interview.Model;
using System.Collections.Generic;
using System.Linq;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Infrastructure.Persistance;

namespace Solentive.Interview.Service
{
    public class SeminarService : ISeminarService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISeminarRepository _seminarRepository;

        public SeminarService(IUnitOfWork unitOfWork, ISeminarRepository seminarRepository)
        {
            _unitOfWork = unitOfWork;
            _seminarRepository = seminarRepository;
        }

        public IList<Seminar> GetSeminars()
        {
            return _seminarRepository.GetSeminars().ToList();
        }
    }
}
