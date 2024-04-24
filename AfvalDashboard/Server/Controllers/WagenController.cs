using AfvalDashboard.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AfvalDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WagenController : ControllerBase
    {

        private readonly ILogger<WagenController> _logger;

        public WagenController(ILogger<WagenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Wagen> Get()
        {
            return MaakTienWagens();
        }

        private static IEnumerable<Wagen> MaakTienWagens()
        {
            return new List<Wagen>()
            {
                new Wagen(1, "Wagen #1", true, false, "DAF"),
                new Wagen(2, "Wagen #2", false,true, "Scania"),
                new Wagen(3, "Wagen #3", true, false, "Mercedes"),
                new Wagen(4, "Wagen #4", false,true, "Renault"),
                new Wagen(5, "Wagen #5", true, false, "Volvo"),
                new Wagen(6, "Wagen #6", false,true, "DAF"),
                new Wagen(7, "Wagen #7", true, false, "Scania"),
                new Wagen(8, "Wagen #8", false, true, "Mercedes"),
                new Wagen(9, "Wagen #9", true, false, "Renault"),
                new Wagen(10,"Wagen #10", false, true, "Volvo")
            };
        }
    }
}
