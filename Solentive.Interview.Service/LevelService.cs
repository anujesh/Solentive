using Solentive.Interview.Model;
using System.Collections.Generic;
using System.Linq;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Data.Infrastructure.Persistance;
using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;

namespace Solentive.Interview.Service
{
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILevelRepository _levelRepository;

        public LevelService(IUnitOfWork unitOfWork, ILevelRepository levelRepository)
        {
            _unitOfWork = unitOfWork;
            _levelRepository = levelRepository;
        }

        public IList<Level> GetLevels()
        {
            return _levelRepository.GetAll().ToList();
        }

        public bool AddLevel(Level level)
        {
            _unitOfWork.Levels.Add(level);
            return (_unitOfWork.Save() > 0);
        }
    }
}
