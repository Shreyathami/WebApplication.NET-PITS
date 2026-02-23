using Microsoft.AspNetCore.Mvc;
using UserForm.Models;

namespace UserForm.Controllers
{
    public class UserController : Controller
    {
        // Show form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Handle form submit
        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Redirect to Success page and pass user's name
                return RedirectToAction("Index", "Dashboard", new { name = model.Name });
            }

            // If validation fails, reload the form
            return View(model);
        }

        // Success page
        // [HttpGet]
        // public IActionResult Success(string name)
        // {
        //     ViewBag.Name = name;
        //     return View();
        // }
    }
}