using TaskManager.Core.Models.Domains;
using Task=TaskManager.Core.Models.Domains.Task;

namespace TaskManager.Core.ViewModels
{
    public class TasksViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public FilterTasks FilterTasks { get; set; }
    }
}
