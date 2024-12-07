using TaskManager.Core.Repositories;
using TaskManager.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Core
{
    public interface IUnitOfWork
    {
        ITaskRepository Task { get; }
        void Complete();
    }
}
