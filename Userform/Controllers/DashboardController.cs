using Microsoft.AspNetCore.Mvc;
using UserForm.Models;
using UserForm.Services;

namespace UserForm.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUserService _userService;

        public DashboardController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index(Guid id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
    }
}