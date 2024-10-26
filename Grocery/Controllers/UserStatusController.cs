using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class UserStatusController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public UserStatusController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> UserStatusList()
        {
            IEnumerable<UserStatus> list = _context.UserStatuss;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserStatus userstatuss)
        {
            if (ModelState.IsValid)
            {
                _context.UserStatuss.Add(userstatuss);
                _context.SaveChanges();
                return RedirectToAction("UserStatusList");
            }


            return View(userstatuss);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var UserStatuss = _context.UserStatuss.Find(Id);
            if (UserStatuss != null)
            {
                return View(UserStatuss);
            }
            return View(UserStatuss);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var UserStatuss = await _context.UserStatuss.FindAsync(Id);
            if (UserStatuss != null)
            {
                _context.UserStatuss.Remove(UserStatuss);
                _context.SaveChanges();
                return RedirectToAction("UserStatusList");
            }

            return RedirectToAction("UserStatusList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var UserStatuss = _context.UserStatuss.Find(Id);
            if (UserStatuss != null)
            {
                return View(UserStatuss);
            }
            return View(UserStatuss);
        }
        [HttpPost]
        public IActionResult Edit(UserStatus userstatuss)
        {
            if (ModelState.IsValid)
            {
                _context.UserStatuss.Update(userstatuss);
                _context.SaveChanges();
                return RedirectToAction("UserStatusList");
            }
            return View(userstatuss);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var UserStatuss = _context.UserStatuss.Find(Id);
            if (UserStatuss != null)
            {
                return View(UserStatuss);
            }
            return View(UserStatuss);
        }

    }
}

