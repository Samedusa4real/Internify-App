using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.PrivacyNotice;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Forage.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _service;

        public AboutController(IAboutService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();
            return View(result.items);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(AboutPostDto dto)
		{
			if (!ModelState.IsValid)
			{
				return View(dto);
			}
			var result = await _service.CreateAsync(dto);
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
			var result = await _service.GetAsync(id);
			if (result.StatusCode	== 404)
			{
				return NotFound();
			}
			return View(result.items);
		}

		public async Task<IActionResult> Update(int id, AboutUpdateDto dto)
		{
			if (!ModelState.IsValid)
			{
				return View(dto);
			}
			var result = await _service.UpdateAsync(id, dto);
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
