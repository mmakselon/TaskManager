using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Models.Domains;
using Task = TaskManager.Core.Models.Domains.Task;

namespace TaskManager.Core
{
    public interface IApplicationDbContext
    {
        DbSet<Task> Tasks { get; set; }
        DbSet<Category> Categories { get; set; }
        int SaveChanges();
    }
}
