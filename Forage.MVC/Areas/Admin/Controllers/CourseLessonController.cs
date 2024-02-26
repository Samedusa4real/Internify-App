using Forage.Core.Entities;
using Forage.Service.Dtos.CourseLessons;
using Forage.Service.Dtos.Skills;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Forage.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CourseLessonController : Controller
    {
        private readonly ICourseLessonService _service;
        private readonly ICourseService _courseService;
        private readonly ICourseLessonLevelService _levelService;
        public CourseLessonController(ICourseLessonService service, ICourseService courseService, ICourseLessonLevelService levelService)
        {
            _service = service;
            _courseService = courseService;
            _levelService = levelService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _courseService.GetAllAsync();
            ViewBag.Courses = result.items;

            result = await _levelService.GetAllAsync();
            ViewBag.Levels = result.items;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseLessonPostDto dto)
        {
            var result = await _courseService.GetAllAsync();
            ViewBag.Courses = result.items;

            result = await _levelService.GetAllAsync();
            ViewBag.Levels = result.items;

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            result = await _service.CreateAsync(dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _courseService.GetAllAsync();
            ViewBag.Courses = result.items;

            result = await _levelService.GetAllAsync();
            ViewBag.Levels = result.items;


            result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id, CourseLessonUpdateDto dto)
        {
            var result = await _courseService.GetAllAsync();
            ViewBag.Courses = result.items;

            result = await _levelService.GetAllAsync();
            ViewBag.Levels = result.items;

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            result = await _service.UpdateAsync(id, dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
