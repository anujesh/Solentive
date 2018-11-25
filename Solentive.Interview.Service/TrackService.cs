using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solentive.Interview.Data;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Data.Infrastructure.Persistance;
using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;

namespace Solentive.Interview.Service
{
    public class TrackService : ITrackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITrackRepository _trackRepository;


        public TrackService(IUnitOfWork unitOfWork, ITrackRepository trackRepository)
        {
            _unitOfWork = unitOfWork;
            _trackRepository = trackRepository;
        }

        public IList<Track> GetTracks()
        {
            return _trackRepository.GetAll().ToList();
        }

        public bool AddTrack(Track track)
        {
            _unitOfWork.Tracks.Add(track);
            return (_unitOfWork.Save() > 0);
        }
    }
}
