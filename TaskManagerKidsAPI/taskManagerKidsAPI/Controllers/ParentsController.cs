using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskManagerKidsAPI.Context;
using taskManagerKidsAPI.Models;

namespace taskManagerKidsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ParentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Parent>> Get()
        {
            var parents = _context.Parents.ToList();
            if (parents is null)
            {
                return NotFound("Resultados não encontrados...");
            }
            return parents;
        }
    }
}
