using Forage.Service.Services.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Forage.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly LanguageService _localizer;

        public HomeController(LanguageService localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewBag.Meselen = _localizer.GetKey("example").Value;
            return View();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
