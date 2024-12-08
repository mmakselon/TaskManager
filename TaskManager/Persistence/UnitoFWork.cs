﻿using TaskManager.Core;
using TaskManager.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Persistence;
using TaskManager.Core.Repositories;
using Task = TaskManager.Core.Models.Domains.Task;

namespace MyTasks.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContext context)
        {
            _context = context;
            Task = new TaskRepository(context);
        }

        public ITaskRepository Task { get; set; }

        ITaskRepository IUnitOfWork.Task => throw new NotImplementedException();

        public void Complete()
        {
            _context.SaveChanges();
        }

    }
}
