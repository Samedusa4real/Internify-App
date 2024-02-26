using Forage.Core.Entities;
using Forage.Service.Dtos.Accounts;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Forage.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IIdentityUserService _service;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(IIdentityUserService service, UserManager<AppUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.Login(dto);
            if (result.StatusCode != 200)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction("index", "home");
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            var result = await _service.LogOut();
            return RedirectToAction("index", "home");
        }
        [Authorize]
        public async Task<IActionResult> Update()
        {
            var result = await _service.GetCurrentUser();
            if (result.StatusCode != 200)
            {
                return NotFound();
            }
            AppUser user = (AppUser)result.items;
            UpdateDto dto = new UpdateDto()
            {
                UserName = user.UserName,
                Email = user.Email,
            };
            return View(dto);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(UpdateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.Update(dto,null);
            if (result.StatusCode != 203)
            {
                if (result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction("index","home");
        }
        //public async Task<IActionResult> AdminCreate()
        //{
        //    AppUser SuperAdmin = new AppUser
        //    {
        //        Email = "superadmin@forage.com",
        //        UserName = "SuperAdmin",
        //        EmailConfirmed = true
        //    };
        //    await _userManager.CreateAsync(SuperAdmin, "Admin123.");
        //    AppUser Admin = new AppUser
        //    {
        //        Email = "admin@forage.com",
        //        UserName = "Admin",
        //        EmailConfirmed = true
        //    };
        //    await _userManager.CreateAsync(Admin, "Admin123.");

        //    await _userManager.AddToRoleAsync(SuperAdmin, "SuperAdmin");
        //    await _userManager.AddToRoleAsync(Admin, "Admin");
        //    return Json("ok");
        //}

    }
}
