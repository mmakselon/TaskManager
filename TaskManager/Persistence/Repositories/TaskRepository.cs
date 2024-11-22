using TaskManager.Core.Models.Domains;
using Task = TaskManager.Core.Models.Domains.Task;

namespace TaskManager.Persistence.Repositories
{
    public class TaskRepository
    {

        public IEnumerable<Task> Get(string userId, bool isExecuted = false, int categoryId = 0, string titl = null)
        {
            throw new NotImplementedException();
        }

        internal Task Get(int id, string userId)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        internal void Add(Task task)
        {
            throw new NotImplementedException();
        }

        internal void Update(Task task)
        {
            throw new NotImplementedException();
        }

        internal void Delete(int id, string userId)
        {
            throw new NotImplementedException();
        }

        internal void Finish(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
