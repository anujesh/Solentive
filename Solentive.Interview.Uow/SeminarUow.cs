using Solentive.Interview.Data;
using Solentive.Interview.Model;
using Solentive.Interview.Uow.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Uow
{
    public class SeminarUow : ISeminarUow
    {
        #region Variables

        private EFRepository<Location> _locations = null;
        private EFRepository<Track> _tracks = null;
        private EFRepository<Level> _levels = null;
        private EFRepository<Seminar> _seminars = null;

        #endregion

        #region Constructors

        public SeminarUow()
        {
            InitialiseDbContext(null);
        }

        public SeminarUow(SeminarDbContext context)
        {
            InitialiseDbContext(context);
        }

        #region Properties

        private DbContext Context { get; set; }

        #endregion

        #endregion

        #region Private Methods

        protected void InitialiseDbContext(DbContext context)
        {
            Context = context == null ? new SeminarDbContext() : context;
            Context.Configuration.LazyLoadingEnabled = false;
            Context.Configuration.ProxyCreationEnabled = false;
            Context.Configuration.ValidateOnSaveEnabled = false;
        }

        #endregion

        #region Public Methods

        public bool Commit()
        {
            return this.Context.SaveChanges() > 0;
        }

        #endregion

        #region ISeminarUow Implementation

        public IRepository<Location> Locations
        {
            get { return _locations ?? (_locations = new EFRepository<Location>(this.Context)); }
        }

        public IRepository<Track> Tracks
        {
            get { return _tracks ?? (_tracks = new EFRepository<Track>(this.Context)); }
        }

        public IRepository<Level> Levels
        {
            get { return _levels ?? (_levels = new EFRepository<Level>(this.Context)); }
        }

        public IRepository<Seminar> Seminars
        {
            get { return _seminars ?? (_seminars = new EFRepository<Seminar>(this.Context)); }
        }

        #endregion

        #region IDisposable Implementation

        private bool _disposed = false;

        ~SeminarUow()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // Clear managed resources
                if (this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }

            _disposed = true;
        }

        #endregion
    }
}
