using AfvalDashboard.Server.Controllers;
using AfvalDashboard.Shared;
using Microsoft.Extensions.Logging;
using Moq;

namespace AfvalDashboard.Tests
{
    public class LedigingenControllerTests
    {
        private readonly Mock<ILogger<LedigingenController>> _mockLogger;
        private readonly LedigingenController _controller;

        public LedigingenControllerTests()
        {
            _mockLogger = new Mock<ILogger<LedigingenController>>();
            _controller = new LedigingenController(_mockLogger.Object);
        }

        [Fact]
        public void LedigingenController_ReturnsOneHundredLedigingen()
        {
            // Act
            var result = _controller.Get();

            // Assert
            var ledigingen = Assert.IsAssignableFrom<IEnumerable<Lediging>>(result);
            Assert.Equal(100, ledigingen.Count());
        }
    }
}
