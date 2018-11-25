using Solentive.Interview.Common;
using System;

namespace Solentive.Interview.Model
{
    public class Seminar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Location Location { get; set; }
        public Level Level { get; set; }
        public Track Track { get; set; }

        public double DaysToGo
        {
            get
            {
                return DateCalculations.GetDifferenceInDays(DateTime.Now, this.Date);
            }
        }
    }
}
