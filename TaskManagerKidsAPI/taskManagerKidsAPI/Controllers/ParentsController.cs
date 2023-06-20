using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return NotFound("Parent not found...");
            }
            return parents;
        }

        [HttpGet("{id:int}", Name = "GetParents")]
        public ActionResult<Parent> Get(int id)
        {
            var parents = _context.Parents.FirstOrDefault(p => p.Id == id);
            if (parents is null)
                return NotFound("Parent not found...");

            return parents;
        }

        [HttpGet("kid/{idKid}")]
        public ActionResult<IEnumerable<Kid>> GetKidsByParent(int idKid)
        {
            // Verifique se o Kid existe no banco de dados
            Kid kid = _context.Kids.Include(p => p.Parents).FirstOrDefault(p => p.Id == idKid);

            if (kid is null)
            {
                return NotFound("Kid not found.");
            }

            // Obtenha os Parents relacionados ao Kid
            List<Parent> Parents = kid.Parents.ToList();

            return Ok(Parents);
        }


        [HttpPost]
        public ActionResult Post(Parent parent)
        {
            if (parent is null)
                return BadRequest();

            _context.Parents.Add(parent);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetParents",
                new { id = parent.Id }, parent);
        }
    }
}
