using Forage.Core.Entities;
using Forage.Service.Dtos.Accounts;
using Forage.Service.Dtos.Companies;
using Forage.Service.Services.Implementations;
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
    public class CompanyController : Controller
	{
		private readonly ICompanyService _service;
		private readonly ICompanyIndustryFieldService _companyIndustryFieldService;
		private readonly IIdentityUserService _identityUserService;

        public CompanyController(ICompanyService service, ICompanyIndustryFieldService companyIndustryFieldService, IIdentityUserService identityUserService)
        {
            _service = service;
            _companyIndustryFieldService = companyIndustryFieldService;
            _identityUserService = identityUserService;
        }

        public async Task<IActionResult> Index()
		{
			var result = await _service.GetAllAsync();
			return View(result.items);
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
            var result = await _identityUserService.GetAllUser("Company");
            ViewBag.Users = result.items;
            result = await _companyIndustryFieldService.GetAllAsync();
			ViewBag.CompanyIndustryFields = result.items;
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CompanyPostDto dto)
		{
            var result = await _identityUserService.GetAllUser("Company");
            ViewBag.Users = result.items;
            result = await _companyIndustryFieldService.GetAllAsync();
			ViewBag.CompanyIndustryFields = result.items;
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
        public async Task<IActionResult> Detail(int id)
        {
            var result = await _service.GetDetailAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        [HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			var result = await _companyIndustryFieldService.GetAllAsync();
			ViewBag.CompanyIndustryFields = result.items;
		    result = await _service.GetAsync(id);
			if (result.StatusCode == 404)
			{
				return NotFound();
			}
			return View(result.items);
		}
		public async Task<IActionResult> Update(int id, CompanyUpdateDto dto)
		{
			var result = await _companyIndustryFieldService.GetAllAsync();
			ViewBag.CompanyIndustryFields = result.items;
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
    
    [HttpGet]
    public async Task<IActionResult> Register()
    {
        return View();
    }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterPartnerDto dto)
		{

			if (!ModelState.IsValid)
			{
				return View(dto);
			}
			var result = await _identityUserService.Register(dto, "Company");
			if (result.StatusCode != 200)
			{
				ModelState.AddModelError("", result.Message);
				return View(dto);
			}
			return RedirectToAction(nameof(Index));
		}
}
}
