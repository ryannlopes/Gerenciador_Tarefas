using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return NotFound("Kids not found...");

            return kids;
        }

        [HttpGet("{id:int}", Name = "GetKids")]
        public ActionResult<Kid> Get(int id)
        {
            var kids = _context.Kids.FirstOrDefault(k => k.Id == id);
            if (kids is null)
                return NotFound("Kid not found...");

            return kids;
        }

        [HttpGet("parent/{idParent}")]
        public ActionResult<IEnumerable<Kid>> GetKidsByParent(int idParent)
        {
            // Verifique se o Parent existe no banco de dados
            Parent parent = _context.Parents.Include(p => p.Kids).FirstOrDefault(p => p.Id == idParent);

            if (parent is null)
            {
                return NotFound("Parent not found.");
            }

            // Obtenha os Kids relacionados ao Parent
            List<Kid> kids = parent.Kids.ToList();

            return Ok(kids);
        }


        [HttpPost("{idsParents}")]
        public ActionResult Post(string idsParents, Kid kid)
        {
            if (kid is null)
                return BadRequest();

            // Obtenha os IDs de Parents fornecidos separados por vírgula
            string[] idsArray = idsParents.Split(',');

            // Verifique se todos os Parents existem no banco de dados
            List<Parent> parents = _context.Parents.Where(p => idsArray.Contains(p.Id.ToString())).ToList();

            if (parents.Count != idsArray.Length)
            {
                return BadRequest("One or more Parents not found.");
            }

            // Associe o Kid aos Parents
            foreach (Parent parent in parents)
            {
                parent.Kids.Add(kid);
                kid.Parents.Add(parent);
            }

            _context.Kids.Add(kid);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetKids",
                new { id = kid.Id }, kid);
        }
    }
}
