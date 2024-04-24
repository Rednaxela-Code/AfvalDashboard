using AfvalDashboard.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AfvalDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedewerkerController : ControllerBase
    {

        private readonly ILogger<MedewerkerController> _logger;

        public MedewerkerController(ILogger<MedewerkerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Medewerker> Get()
        {
            return MaakVierMedewerkers();
        }

        private static IEnumerable<Medewerker> MaakVierMedewerkers()
        {
            return new List<Medewerker>()
            {
                new Medewerker(1, "Alexander", "Nijman", new DateOnly(1992, 01, 26),
                new Adres(1, "Brugweg", "113", "6882ME", "Velp")),
                new Medewerker(2, "Hans", "Anker", new DateOnly(1973, 03, 20),
                new Adres(2, "Lijnstraat", "3", "1243AB", "Amsterdorp")),
                new Medewerker(3, "Mirjam", "Touw", new DateOnly(1948, 12, 03),
                new Adres(3, "Bloemhof", "4", "7294TE", "Eindhoven")),
                new Medewerker(3, "Tony", "Blontana", new DateOnly(1952, 04, 03),
                new Adres(3, "DeWittStraat", "87", "5671NU", "Groningen")),
            };
        }
    }
}
