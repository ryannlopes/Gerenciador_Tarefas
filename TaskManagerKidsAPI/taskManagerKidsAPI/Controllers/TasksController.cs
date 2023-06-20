using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return NotFound("Tasks not found...");
            }
            return tasks;
        }

        [HttpGet("{id:int}", Name = "getInformationTasks")]
        public ActionResult<Task> Get(int id)
        {
            var tasks = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (tasks is null)
                return NotFound("Task not found...");

            return tasks;
        }

        [HttpPost]
        public ActionResult Post(Task task)
        {
            if (task is null)
                return BadRequest();

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return new CreatedAtRouteResult("getInformationTasks",
                new { id = task.Id }, task);
        }

        [HttpPut("{id:int}/inprogress")]
        public IActionResult UpdateTaskStatusInProgress(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound("Task not found...");
            }

            task.Status = "Em andamento";
            _context.SaveChanges();

            return Ok(task);
        }


        [HttpPut("{id:int}/complete")]
        public IActionResult UpdateTaskStatusComplete(int id)
        {
            var task = _context.Tasks.Include(t => t.Kid).FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound("Task not found...");
            }

            task.Status = "Concluído";
            task.Kid.Score += task.GainScore;
            _context.SaveChanges();

            return Ok(task);
        }

    }
}
