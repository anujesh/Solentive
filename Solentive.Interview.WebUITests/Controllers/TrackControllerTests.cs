using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Solentive.Interview.Logging.Interfaces;
using Solentive.Interview.Model;
using Solentive.Interview.Service.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers.Tests
{
    [TestClass()]
    public class TrackControllerTests
    {
        private readonly Mock<ITrackService> _mockTrackService = new Mock<ITrackService>();
        private readonly Mock<ILoggingService> _mockLoggingService = new Mock<ILoggingService>();
 
        [TestMethod()]
        public void List_ViewReturned_ShouldMatchExpectedView()
        {
            var expected = new List<Track>{
                new Track()
                {
                    Id = 1,
                    Name = "test1"
                },
                new Track()
                {
                    Id = 2,
                    Name = "test2"
                }
            };
            _mockTrackService.Setup(x => x.GetTracks()).Returns(() => expected);
            var controller = new TrackController(_mockTrackService.Object,_mockLoggingService.Object);
            var result = (ViewResult)controller.List();
            Assert.AreEqual("List", result.ViewName);
        }
    }
}