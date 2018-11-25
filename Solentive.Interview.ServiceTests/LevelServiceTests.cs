using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Solentive.Interview.Data.Infrastructure.Persistance;
using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Model;
using System.Collections.Generic;
using System.Linq;

namespace Solentive.Interview.Service.Tests
{
    [TestClass()]
    public class LevelServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork = new Mock<IUnitOfWork>();
        private readonly Mock<ILevelRepository> _mockLevelRepository = new Mock<ILevelRepository>();
        List<Level> _randomLevels = new List<Level>();

        public List<Level> SetupLevels()
        {
            Level level1 = new Level
            {
                Id = 1,
                Name = "test",
                Scaling = 1
            };
            _randomLevels.Add(level1);
            Level level2 = new Level
            {
                Id = 1,
                Name = "test2",
                Scaling = 2
            };
            _randomLevels.Add(level2);
            return _randomLevels;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _mockLevelRepository.Setup(x => x.GetAll()).Returns(() => _randomLevels);
        }

        [TestMethod()]
        public void GetLevelsTest()
        {
            var expected = SetupLevels();
            var levelService = new LevelService(_mockUnitOfWork.Object, _mockLevelRepository.Object);
            var result = levelService.GetLevels();
            CollectionAssert.AreEqual(result.ToList(), expected);
        }
    }
}
