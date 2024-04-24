using AfvalDashboard.Server.Controllers;
using AfvalDashboard.Shared;
using Microsoft.Extensions.Logging;
using Moq;

namespace AfvalDashboard.Tests
{
    public class MedewerkerControllerTests
    {
        private readonly Mock<ILogger<MedewerkerController>> _mockLogger;
        private readonly MedewerkerController _controller;

        public MedewerkerControllerTests()
        {
            _mockLogger = new Mock<ILogger<MedewerkerController>>();
            _controller = new MedewerkerController(_mockLogger.Object);
        }

        [Fact]
        public void MedewerkerController_ReturnsFourMedewerkers()
        {
            // Act
            var result = _controller.Get();

            // Assert
            var medewerkers = Assert.IsAssignableFrom<IEnumerable<Medewerker>>(result);
            Assert.Equal(4, medewerkers.Count());
        }
    }
}
