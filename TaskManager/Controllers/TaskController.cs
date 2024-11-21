﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskManager.Core.ViewModels;
using TaskManager.Persistence.Extensions;
using TaskManager.Persistence.Repositories;
using TaskManager.Core.Models.Domains;

namespace TaskManager.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private TaskRepository _taskRepository = new TaskRepository();

        public IActionResult Tasks()
        {
            var userId=User.GetUserId();

            var vm = new TasksViewModel
            {
                FilterTasks = new FilterTasks(),
                Tasks = _taskRepository.Get(userId),
                Categories = _taskRepository.GetCategories()
            };

            return View();
        }
    }
}
