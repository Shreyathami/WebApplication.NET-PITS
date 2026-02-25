using Microsoft.AspNetCore.Mvc;
using UserForm.Models;

namespace UserForm.Controllers
{
    public class UserController : Controller
    {
        // Temporary in-memory storage
        public static List<UserModel> Users = new List<UserModel>();

        // =========================
        // 1️⃣ Show Create Form
        // =========================
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // =========================
        // 2️⃣ Handle Create Submit
        // =========================
        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();  // Generate GUID
                Users.Add(model);           // Save user to list

                return RedirectToAction("Index", "Dashboard", new { id = model.Id });
            }
            return View(model);
        }

        // =========================
        // 3️⃣ Show Edit Form
        // =========================
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // =========================
        // 4️⃣ Handle Edit Submit
        // =========================
        [HttpPost]
        public IActionResult Edit(UserModel model)
        {
            var user = Users.FirstOrDefault(x => x.Id == model.Id);

            if (user != null)
            {
                user.Name = model.Name;
                user.Email = model.Email;
                user.Age = model.Age;   // ✅ IMPORTANT (this was missing)
            }

            return RedirectToAction("Index", "Dashboard", new { id = model.Id });
        }
    }
}