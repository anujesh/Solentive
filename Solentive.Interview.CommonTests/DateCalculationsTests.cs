using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solentive.Interview.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Common.Tests
{
    [TestClass()]
    public class DateCalculationsTests
    {

        [TestMethod]
        public void GetDifferenceInDaysTest_SameDates_returnZero()
        {
            var startDate = new DateTime(DateTime.Now.Year, 2, 2);
            var endDate = new DateTime(DateTime.Now.Year, 2, 2);
            Assert.IsTrue(DateCalculations.GetDifferenceInDays(startDate, endDate).Equals(0));
        }
        [TestMethod]
        public void GetDifferenceInDaysTest_OneDaysDifference_returnsOne()
        {
            var startDate = new DateTime(DateTime.Now.Year, 2, 2);
            var endDate = new DateTime(DateTime.Now.Year, 2, 3);
            Assert.IsTrue(DateCalculations.GetDifferenceInDays(startDate, endDate).Equals(1));
        }
        [TestMethod]
        public void GetWeekStartDateTest_SundaysDate_ReturnsLastMondaysDate()
        {
            var SundayDate = new DateTime(2018,11, 25);
            var ExpectedDate = new DateTime(2018, 11,19);           
            Assert.IsTrue(DateCalculations.GetWeekStartDate(SundayDate).ToShortDateString().Equals(ExpectedDate.ToShortDateString()));
        }
        [TestMethod]
        public void GetWeekEndDateTest_SundaysDate_ReturnsSameSundaysDate()
        {
            var SundayDate = new DateTime(2018, 11, 25);
            var ExpectedDate = new DateTime(2018, 11,25);
            Assert.IsTrue(DateCalculations.GetWeekEndDate(SundayDate).ToShortDateString().Equals(ExpectedDate.ToShortDateString()));
        }
    }
}