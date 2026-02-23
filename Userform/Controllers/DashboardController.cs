using Microsoft.AspNetCore.Mvc;

namespace UserForm.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}