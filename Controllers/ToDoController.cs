using ApiTodo.Data;
using ApiTodo.Model;
using ApiTodo.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ApiTodo.Controllers
{
    [ApiController]
    [Route("/Api")]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoRepository _repo;

        public ToDoController(ITodoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var ListaTodo = _repo.GetTasks();

            return Ok(ListaTodo);
        }
        [HttpGet("{id:int}", Name = "GetTodos")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult OneTask(int id)
        {
            var oneTask = _repo.OneTask(id);

            if (oneTask == null)
            {
                return NotFound($"No se pudo entcontrar el id: {id}");
            }
            return Ok(oneTask);
        }
        [HttpPost]
        public IActionResult PostTask(Tasks tasks)
        {
            _repo.PostTask(tasks);
            return Created("GetTodos", new { id = tasks.idTask });
        }
    }
}
