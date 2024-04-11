﻿using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Forage.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class InternCourseTestController : Controller
    {
        private readonly ICourseService _service;

        public InternCourseTestController(ICourseService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllTestAsync();
            return View(result.items);
        }
    }
}
