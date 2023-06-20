using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return NotFound("Rewards not found...");
            }
            return rewards;
        }

        [HttpGet("{id:int}", Name = "GetRewards")]
        public ActionResult<Reward> Get(int id)
        {
            var rewards = _context.Rewards.FirstOrDefault(r => r.Id == id);
            if (rewards is null)
                return NotFound("Reward not found...");

            return rewards;
        }

        [HttpPost]
        public ActionResult Post(Reward reward)
        {
            if (reward is null)
                return BadRequest();

            _context.Rewards.Add(reward);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetRewards",
                new { id = reward.Id }, reward);
        }

        [HttpPut("{kidId:int}/redeem/{rewardId:int}")]
        public IActionResult RedeemReward(int kidId, int rewardId)
        {
            var kid = _context.Kids.FirstOrDefault(k => k.Id == kidId);
            var reward = _context.Rewards.FirstOrDefault(r => r.Id == rewardId);

            if (kid == null || reward == null)
            {
                return NotFound("Kid or Reward not found...");
            }

            if (kid.Score < reward.Score)
            {
                return BadRequest("Kid does not have enough score to redeem the reward.");
            }

            kid.Score -= reward.Score;
            _context.SaveChanges();

            return Ok(kid);
        }
    }
}
