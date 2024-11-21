using TaskManager.Core.Models.Domains;
using Task = TaskManager.Core.Models.Domains.Task;

namespace TaskManager.Persistence.Repositories
{
    public class TaskRepository
    {

        public IEnumerable<Task> Get(string userId)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
