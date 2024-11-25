﻿using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Models.Domains;
using Task = TaskManager.Core.Models.Domains.Task;

namespace TaskManager.Persistence.Repositories
{
    public class TaskRepository
    {
        private ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
                _context = context; 
        }

        public IEnumerable<Task> Get(string userId, bool isExecuted = false, int categoryId = 0, string title = null)
        {
            var tasks = _context.Tasks
                .Include(x=> x.Category)
                .Where(x=>x.UserId==userId &&
                x.IsExecuted == isExecuted);

            if (categoryId!= 0)
                tasks = tasks.Where(x => x.CategoryId == categoryId);

            if(!string.IsNullOrWhiteSpace(title))
                tasks = tasks.Where(x => x.Title.Contains(title));

            return tasks.OrderBy(x=>x.Term).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.OrderBy(x=>x.Name).ToList();
        }

        public Task Get(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public void Add(Task task)
        {
            throw new NotImplementedException();
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public void Finish(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
