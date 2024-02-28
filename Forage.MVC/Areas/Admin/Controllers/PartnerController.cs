using Forage.Core.Entities;
using Forage.Service.Dtos.Partners;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.ContentModel;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace Forage.MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class PartnerController : Controller
	{
		private readonly IPartnerService _service;

		public PartnerController(IPartnerService service)
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
		public async Task<IActionResult> Create(PartnerPostDto dto)
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
			if (result.StatusCode == 404)
			{
				return NotFound();
			}
			return View(result.items);
		}
		public async Task<IActionResult> Update(int id, PartnerUpdateDto dto)
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
