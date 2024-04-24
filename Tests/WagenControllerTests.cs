using AfvalDashboard.Server.Controllers;
using AfvalDashboard.Shared;
using Microsoft.Extensions.Logging;
using Moq;

namespace AfvalDashboard.Tests
{
    public class WagenControllerTests
    {
        private readonly Mock<ILogger<WagenController>> _mockLogger;
        private readonly WagenController _controller;

        public WagenControllerTests()
        {
            _mockLogger = new Mock<ILogger<WagenController>>();
            _controller = new WagenController(_mockLogger.Object);
        }

        [Fact]
        public void WagenController_ReturnsTenWagenObjects()
        {
            // Act
            var result = _controller.Get();

            // Assert
            var wagens = Assert.IsAssignableFrom<IEnumerable<Wagen>>(result);
            Assert.Equal(10, wagens.Count());
        }
    }
}
