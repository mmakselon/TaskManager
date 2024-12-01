﻿using TaskManager.Core;
using TaskManager.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Persistence;

namespace MyTasks.Persistence
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public TaskRepository Task { get; set; }

        public void Complete()
        {
            _context.SaveChanges();
        }

    }
}