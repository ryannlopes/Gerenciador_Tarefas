using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskManagerKidsAPI.Context;
using taskManagerKidsAPI.Models;
using Reward = taskManagerKidsAPI.Models.Reward;

namespace taskManagerKidsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RewardsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Reward>> Get()
        {
            var rewards = _context.Rewards.ToList();
            if (rewards is null)
            {
                return NotFound("Resultados não encontrados...");
            }
            return rewards;
        }
    }
}
