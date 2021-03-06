﻿using Solentive.Interview.Data.Configuration;
using Solentive.Interview.Model;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Solentive.Interview.Data
{
    public class SeminarDbContext : DbContext
    {
        #region Constructors

        public SeminarDbContext()
            : base(ConfigurationManager.ConnectionStrings["SeminarDb"].ConnectionString)
        {
            Database.SetInitializer<SeminarDbContext>(new SeminarDbInitializer());

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        #endregion

        #region Methods
        public virtual int Commit()
        {
            try
            {
                var result = base.SaveChanges();
                return result;
            }
            catch (Exception)
            {
               
            }
            return 0;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configure entity configurations (navigation properties, etc).
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new TrackConfiguration());
            modelBuilder.Configurations.Add(new LevelConfiguration());
            modelBuilder.Configurations.Add(new SeminarConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Properties

        public DbSet<Location> Locations { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<Seminar> Seminars { get; set; }

        #endregion
    }
}
