using ApiTodo.Controllers;
using ApiTodo.Model;

namespace ApiTodo.Repository.IRepository
{
    public interface ITodoRepository
    {
        ICollection<Tasks> GetTasks();
        Tasks OneTask(int id);
    }
}
