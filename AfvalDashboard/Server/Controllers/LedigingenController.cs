using AfvalDashboard.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AfvalDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedigingenController : ControllerBase
    {

        private readonly ILogger<LedigingenController> _logger;

        public LedigingenController(ILogger<LedigingenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Lediging> Get()
        {
            return MaakHonderdLedigingen();
        }

        private static IEnumerable<Lediging> MaakHonderdLedigingen()
        {
            var random = new Random();
            var list = new List<Lediging>();

            for (int i = 1; i < 101; i++)
            {
                var lediging = new Lediging(i, DateTime.Now.AddHours(i), random.NextDouble() * 100, random.Next(2) == 0, random.Next(1, 10));
                list.Add(lediging);
            }
            return list;
        }
    }
}
