using Forage.Core.Entities;
using Forage.Service.Dtos.Courses;
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
    public class CourseController : Controller
    {
        private readonly ICourseService _service;
        private readonly ICompanyService _companyService;
        private readonly ICourseCategoryService _courseCategoryService;
        private readonly ICourseLevelService _courseLevelService;
        private readonly ISkillService _skillService;

        public CourseController(ICourseService service, ICompanyService companyService, ICourseCategoryService courseCategoryService, ICourseLevelService courseLevelService, ISkillService skillService)
        {
            _service = service;
            _companyService = companyService;
            _courseCategoryService = courseCategoryService;
            _courseLevelService = courseLevelService;
            _skillService = skillService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _companyService.GetAllAsync();
            ViewBag.Companies = result.items;

            result = await _courseCategoryService.GetAllAsync();
            ViewBag.CourseCategories = result.items;

            result = await _courseLevelService.GetAllAsync();
            ViewBag.CourseLevels = result.items;

            result = await _skillService.GetAllAsync();
            ViewBag.Skills = result.items;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursePostDto dto)
        {
            var result = await _companyService.GetAllAsync();
            ViewBag.Companies = result.items;

            result = await _courseCategoryService.GetAllAsync();
            ViewBag.CourseCategories = result.items;

            result = await _courseLevelService.GetAllAsync();
            ViewBag.CourseLevels = result.items;

            result = await _skillService.GetAllAsync();
            ViewBag.Skills = result.items;

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
            var result = await _companyService.GetAllAsync();
            ViewBag.Companies = result.items;

            result = await _courseCategoryService.GetAllAsync();

            ViewBag.CourseCategories = result.items;

            result = await _courseLevelService.GetAllAsync();
            ViewBag.CourseLevels = result.items;

            result = await _skillService.GetAllAsync();
            ViewBag.Skills = (IEnumerable<Skill>)result.items;


            result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id, CourseUpdateDto dto)
        {
            var result = await _companyService.GetAllAsync();
            ViewBag.Companies = result.items;

            result = await _courseCategoryService.GetAllAsync();
            ViewBag.CourseCategories = result.items;

            result = await _courseLevelService.GetAllAsync();
            ViewBag.CourseLevels = result.items;

            result = await _skillService.GetAllAsync();
            ViewBag.Skills = result.items;

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
