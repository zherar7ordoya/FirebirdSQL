using Microsoft.EntityFrameworkCore;

namespace Superserver;

public class TodoContext : DbContext
{
    public DbSet<TodoItem> Tareas => Set<TodoItem>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseFirebird("User=SYSDBA;Password=admin;Database=TODO.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;");
    }
}