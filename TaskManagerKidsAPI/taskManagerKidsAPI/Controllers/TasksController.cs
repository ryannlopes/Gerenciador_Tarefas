using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskManagerKidsAPI.Context;
using taskManagerKidsAPI.Models;
using Task = taskManagerKidsAPI.Models.Task;

namespace taskManagerKidsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            var tasks = _context.Tasks.ToList();
            if (tasks is null)
            {
                return NotFound("Resultados não encontrados...");
            }
            return tasks;
        }
    }
}
