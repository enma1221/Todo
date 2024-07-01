using ApiTodo.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiTodo.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        : base(options) { }

        public DbSet<Tasks> Todos => Set<Tasks>();
    }
}
