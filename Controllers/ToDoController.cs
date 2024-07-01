using ApiTodo.Data;
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
        public IActionResult OneTask(int id)
        {
            var oneTask = _repo.OneTask(id);
            return Ok(oneTask);
        }


    }
}
