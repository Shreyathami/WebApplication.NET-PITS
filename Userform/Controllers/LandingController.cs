using Microsoft.AspNetCore.Mvc;

namespace UserForm.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TotalUsers = 250;
            ViewBag.Projects = 45;
            ViewBag.Awards = 12;

            return View();
        }
    }
}