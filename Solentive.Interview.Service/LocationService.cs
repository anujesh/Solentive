using Solentive.Interview.Model;
using System.Collections.Generic;
using System.Linq;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Data.Infrastructure.Persistance;

namespace Solentive.Interview.Service
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Location> GetLocations()
        {
            return _unitOfWork.Locations.GetAll().ToList();
        }

        public bool AddLocation(Location location)
        {
            _unitOfWork.Locations.Add(location);
            return (_unitOfWork.Save() > 0);
        }
    }
}
