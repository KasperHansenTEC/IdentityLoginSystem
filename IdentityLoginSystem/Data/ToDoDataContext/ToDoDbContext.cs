using Microsoft.EntityFrameworkCore;

namespace IdentityLoginSystem.Data.ToDoDataContext
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cpr> Cprs { get; set; }
        public DbSet<Todolist> Todolists { get; set; }
    }

}
