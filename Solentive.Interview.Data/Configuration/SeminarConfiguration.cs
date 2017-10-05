using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data.Configuration
{
    public class SeminarConfiguration : EntityTypeConfiguration<Seminar>
    {
        public SeminarConfiguration()
        {
            HasKey(i => i.Id);

            Property(i => i.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(i => i.Level)
                .WithMany()
                .Map(i => i.MapKey("LevelId"));

            HasRequired(i => i.Location)
                .WithMany()
                .Map(i => i.MapKey("LocationId"));

            HasRequired(i => i.Track)
                .WithMany()
                .Map(i => i.MapKey("TrackId"));
        }
    }
}
