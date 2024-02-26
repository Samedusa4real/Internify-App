using Forage.Core.Entities;
using Forage.Service.Dtos.HelpMessage;
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
    public class HelpMessageController : Controller
	{
		private readonly IHelpMessageService _service;

		public HelpMessageController(IHelpMessageService service)
		{
			_service = service;
		}

		public async Task<IActionResult> Index()
		{
			var result = await _service.GetAllAsync();
			return View(result.items);
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
