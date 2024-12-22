using System.Threading.Tasks;
using TaskManager.Core;
using TaskManager.Core.Models.Domains;
using TaskManager.Core.Repositories;

namespace TaskManager.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private IApplicationDbContext _context;
        public CategoryRepository(IApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Delete(int id, string userId)
        {
            var categoryToDelete = _context.Categories.Single(x=>x.Id == id && x.UserId == userId);
            _context.Categories.Remove(categoryToDelete);
        }

        public IEnumerable<Category> Get(string userId)
        {
            return _context.Categories
                .Where(x=>x.UserId == userId)
                .OrderBy(x=>x.Name);
        }

        public Category Get(int id, string userId)
        {
            return _context.Categories
                .Single(x => x.UserId == userId && x.Id == id);
        }

        public void Update(Category category)
        {
            var categoryToUpdate = _context.Categories.Single(x => x.Id == category.Id);

            categoryToUpdate.Name = category.Name;
        }
    }
}
