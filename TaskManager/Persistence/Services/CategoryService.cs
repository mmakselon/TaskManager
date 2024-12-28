using TaskManager.Core;
using TaskManager.Core.Models.Domains;
using TaskManager.Core.Service;

namespace TaskManager.Persistence.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Category category)
        {
            _unitOfWork.Category.Add(category);
            _unitOfWork.Complete();
        }

        public void Delete(int id, string userId)
        {
            _unitOfWork.Category.Delete(id, userId);
            _unitOfWork.Complete();
        }

        public IEnumerable<Category> Get(string userId)
        {
            return _unitOfWork.Category.Get(userId);
        }

        public Category Get(int id, string userId)
        {
            _unitOfWork.Category.Get(id, userId);
        }

        public void Update(Category category)
        {
            _unitOfWork.Category.Update(category);
            _unitOfWork.Complete();
        }
    }
}
