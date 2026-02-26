using Microsoft.AspNetCore.Mvc;
using UserForm.Models;
using UserForm.Services;

namespace UserForm.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.CreateUser(model);
                return RedirectToAction("Report");
            }

            return View(model);
        }

        public IActionResult Edit(Guid id)
        {
            var user = _userService.GetUserById(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(UserModel model)
        {
            _userService.UpdateUser(model);
            return RedirectToAction("Report");
        }

        public IActionResult Deactivate(Guid id)
        {
            _userService.DeactivateUser(id);
            return RedirectToAction("Report");
        }

        public IActionResult Report()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }
    }
}