using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskManager.Core.ViewModels;
using TaskManager.Persistence.Extensions;
using TaskManager.Persistence.Repositories;
using TaskManager.Core.Models.Domains;
using Task = TaskManager.Core.Models.Domains.Task;
using TaskManager.Persistence;
using MyTasks.Persistence;

namespace TaskManager.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private UnitOfWork _unitOfWork;

        public TaskController(ApplicationDbContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public IActionResult Tasks()
        {
            var userId = User.GetUserId();

            var vm = new TasksViewModel
            {
                FilterTasks = new FilterTasks(),
                Tasks = _unitOfWork.Task.Get(userId),
                Categories = _unitOfWork.Task.GetCategories()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Tasks(TasksViewModel viewModel)
        {
            var userId = User.GetUserId();

            var tasks = _unitOfWork.Task.Get(userId,
                viewModel.FilterTasks.IsExecuted,
                viewModel.FilterTasks.CategoryId,
                viewModel.FilterTasks.Title);

            return PartialView("_tasksTable", tasks);
        }

        public IActionResult Task(int id = 0)
        {
            var userId = User.GetUserId();

            var task = id == 0 ?
                new Task { Id = 0, UserId = userId, Term = DateTime.Today } :
                _unitOfWork.Task.Get(id, userId);

            var vm = new TaskViewModel
            {
                Task = task,
                Heading = id == 0 ?
                    "Dodawanie nowego zadania" : "Edytowanie zadania",
                Categories = _unitOfWork.Task.GetCategories()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Task(Task task)
        {
            var userId = User.GetUserId();
            task.UserId = userId;

            if (!ModelState.IsValid)
            {
                var vm = new TaskViewModel
                {
                    Task = task,
                    Heading = task.Id == 0 ?
                    "Dodawanie nowego zadania" : "Edytowanie zadania",
                    Categories = _unitOfWork.Task.GetCategories()
                };

                return View("Task", vm);
            }

            if (task.Id == 0)
                _unitOfWork.Task.Add(task);
            else
                _unitOfWork.Task.Update(task);

            _unitOfWork.Complete();

            return RedirectToAction("Tasks");
        }

[HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var userId = User.GetUserId();
                _unitOfWork.Task.Delete(id, userId);
                _unitOfWork.Complete();
            }
            catch (Exception ex)
            {
                //logowanie
                return Json(new { success = false, message = ex.Message });
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult Finish(int id)
        {
            try
            {
                var userId = User.GetUserId();
                _unitOfWork.Task.Finish(id, userId);
                _unitOfWork.Complete();
            }
            catch (Exception ex)
            {
                //logowanie
                return Json(new { success = false, message = ex.Message });
            }

            return Json(new { success = true });
        }


    }
}