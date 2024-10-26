using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class UserController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public UserController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            IEnumerable<User> list = _context.Users;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User users)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(users);
                _context.SaveChanges();
                return RedirectToAction("UserList");
            }


            return View(users);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Users = _context.Users.Find(Id);
            if (Users != null)
            {
                return View(Users);
            }
            return View(Users);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var Users = await _context.Users.FindAsync(Id);
            if (Users != null)
            {
                _context.Users.Remove(Users);
                _context.SaveChanges();
                return RedirectToAction("UserList");
            }

            return RedirectToAction("UserList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Users = _context.Users.Find(Id);
            if (Users != null)
            {
                return View(Users);
            }
            return View(Users);
        }
        [HttpPost]
        public IActionResult Edit(User users)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(users);
                _context.SaveChanges();
                return RedirectToAction("UserList");
            }
            return View(users);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var Users = _context.Users.Find(Id);
            if (Users != null)
            {
                return View(Users);
            }
            return View(Users);
        }


    }
}

