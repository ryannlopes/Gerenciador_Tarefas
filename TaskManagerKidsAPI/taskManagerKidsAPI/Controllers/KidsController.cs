using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskManagerKidsAPI.Context;
using taskManagerKidsAPI.Models;

namespace taskManagerKidsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KidsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public KidsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Kid>> Get()
        {
            var kids = _context.Kids.ToList();
            if (kids is null)
            {
                return NotFound("Resultados não encontrados...");
            }
            return kids;
        }
    }
}
