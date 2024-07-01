using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTodo.Model
{
    public class Tasks
    {
        [Key]
        public int idTask { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
