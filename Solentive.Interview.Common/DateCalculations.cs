using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Common
{
    public class DateCalculations
    {
        public static int GetDifferenceInDays(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate) return 0;

            int count = 0;
            DateTime trackDate = endDate;
            while (trackDate < endDate)
            {
                count++;
                trackDate = trackDate.AddDays(1);
            }
            return count;
        }

        public static DateTime GetWeekEndDate(DateTime date)
        {
            DateTime result = date.Date;
            if (result.DayOfWeek != DayOfWeek.Sunday)
            {
                result = result.AddDays(7 - (int)result.DayOfWeek);
            }

            return result;
        }

        public static DateTime GetWeekStartDate(DateTime date)
        {
            // TODO: To be implemented.

            return date;
        }
    }
}
