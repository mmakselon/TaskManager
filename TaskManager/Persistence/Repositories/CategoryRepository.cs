﻿using TaskManager.Core.Models.Domains;
using TaskManager.Core.Repositories;

namespace TaskManager.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get(string userId)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}