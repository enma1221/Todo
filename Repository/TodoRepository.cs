using ApiTodo.Data;
using ApiTodo.Model;
using ApiTodo.Repository.IRepository;
using System.Linq;

namespace ApiTodo.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AplicationDbContext _db;

        public TodoRepository(AplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<Tasks> GetTasks()
        {

            return _db.Todos.OrderBy(t => t.idTask).ToList();   

        }
        public Tasks OneTask(int id)
        {
            return _db.Todos.FirstOrDefault(t => t.idTask == id);
        }
    }
}
