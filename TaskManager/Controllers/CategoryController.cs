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
using MyTasks.Persistence.Services;
using TaskManager.Core.Service;

namespace TaskManager.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        

    }
}