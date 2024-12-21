using TaskManager.Core.Models.Domains;

namespace TaskManager.Core.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Get(string userId);
        Category Get(int id, string userId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id, string userId);
    }
}
