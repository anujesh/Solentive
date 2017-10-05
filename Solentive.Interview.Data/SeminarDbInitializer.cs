using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data
{
    public class SeminarDbInitializer : DropCreateDatabaseAlways<SeminarDbContext>
    {
        protected override void Seed(SeminarDbContext context)
        {
            #region Locations

            var locationLondon = new Model.Location { Name = "London", Building = "Central Building", RoomNumber = "B101" };
            var locationVienna = new Model.Location { Name = "Vienna", Building = "Central Building", RoomNumber = "B102" };
            var locationSydney = new Model.Location { Name = "Sydney", Building = "Central Building", RoomNumber = "B103" };
            var locationNewYork = new Model.Location { Name = "New York", Building = "Central Building", RoomNumber = "B104" };
            var locationMoscow = new Model.Location { Name = "Moscow", Building = "Central Building", RoomNumber = "B105" };

            context.Locations.Add(locationLondon);
            context.Locations.Add(locationVienna);
            context.Locations.Add(locationSydney);
            context.Locations.Add(locationNewYork);
            context.Locations.Add(locationMoscow);
            context.SaveChanges();

            #endregion

            #region Tracks

            var trackWebDevelopment = new Model.Track { Name = "Web Development" };
            var trackMobileDevelopment = new Model.Track { Name = "Mobile Development" };
            var trackClientSide = new Model.Track { Name = "Client Side Development" };
            var trackServerSide = new Model.Track { Name = "Server Side Development" };
            var trackJavascript = new Model.Track { Name = "Javascript Frameworks" };

            context.Tracks.Add(trackWebDevelopment);
            context.Tracks.Add(trackMobileDevelopment);
            context.Tracks.Add(trackClientSide);
            context.Tracks.Add(trackServerSide);
            context.Tracks.Add(trackJavascript);
            context.SaveChanges();

            #endregion

            #region Levels

            var levelBeginner = new Model.Level { Name = "Beginner", Scaling = 1 };
            var levelIntermediate = new Model.Level { Name = "Intermediate", Scaling = 2 };
            var levelExpert = new Model.Level { Name = "Expert", Scaling = 3 };
            var levelMaster = new Model.Level { Name = "Master", Scaling = 4 };

            context.Levels.Add(levelBeginner);
            context.Levels.Add(levelIntermediate);
            context.Levels.Add(levelExpert);
            context.Levels.Add(levelMaster);
            context.SaveChanges();

            #endregion

            #region Seminars

            context.Seminars.Add(new Seminar { 
                Title = "AngularJS 101", Code = "AJS101", 
                Description = "An overview of AngularJS", Level = levelIntermediate, 
                Location = locationSydney, Track = trackJavascript, Date = DateTime.Now.AddDays(5)});
            
            context.Seminars.Add(new Seminar { 
                Title = "Introduction to MVC", Code = "MVC101", 
                Description = "An overview of ASP.NET MVC", Level = levelIntermediate, 
                Location = locationMoscow, Track = trackServerSide, Date = DateTime.Now.AddDays(2)});
            
            context.Seminars.Add(new Seminar { 
                Title = "Windows Phone Fundamentals", Code = "WPH101", 
                Description = "An overview of Windows Phone", Level = levelBeginner, 
                Location = locationNewYork, Track = trackMobileDevelopment, Date = DateTime.Now.AddDays(-2)});
            
            context.Seminars.Add(new Seminar { 
                Title = "Advanced AngularJS", Code = "AJS789", 
                Description = "An advanced look at AngularJS", Level = levelMaster, 
                Location = locationLondon, Track = trackJavascript, Date = DateTime.Now.AddDays(10) });
            
            context.Seminars.Add(new Seminar { 
                Title = "Advanced MVC", Code = "MVC987", 
                Description = "An advanced look at ASP.NET MVC", Level = levelExpert, 
                Location = locationVienna, Track = trackServerSide, Date = DateTime.Now.AddDays(6)});
            
            context.SaveChanges();

            #endregion

            base.Seed(context);
        }
    }
}
