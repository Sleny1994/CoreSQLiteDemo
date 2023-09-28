using Microsoft.EntityFrameworkCore;

namespace CoreSQLiteDemo.Models
{
    public class SqliteContext : DbContext
    {
        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
