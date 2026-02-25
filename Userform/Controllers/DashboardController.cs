using Microsoft.AspNetCore.Mvc;
using UserForm.Models;
using UserForm.Controllers;

namespace UserForm.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index(Guid id)
        {
            var user = UserController.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
    }
}