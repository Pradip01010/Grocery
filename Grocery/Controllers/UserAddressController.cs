using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class UserAddressController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public UserAddressController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> UserAddressList()
        {
            IEnumerable<UserAddress> list = _context.UserAddresses;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserAddress useraddresses)
        {
            if (ModelState.IsValid)
            {
                _context.UserAddresses.Add(useraddresses);
                _context.SaveChanges();
                return RedirectToAction("UserAddressList");
            }


            return View(useraddresses);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var UserAddresses = _context.UserAddresses.Find(Id);
            if (UserAddresses != null)
            {
                return View(UserAddresses);
            }
            return View(UserAddresses);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var UserAddresses = await _context.UserAddresses.FindAsync(Id);
            if (UserAddresses != null)
            {
                _context.UserAddresses.Remove(UserAddresses);
                _context.SaveChanges();
                return RedirectToAction("UserAddressList");
            }

            return RedirectToAction("UserAddressList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var UserAddresses = _context.UserAddresses.Find(Id);
            if (UserAddresses != null)
            {
                return View(UserAddresses);
            }
            return View(UserAddresses);
        }
        [HttpPost]
        public IActionResult Edit(UserAddress useraddresses)
        {
            if (ModelState.IsValid)
            {
                _context.UserAddresses.Update(useraddresses);
                _context.SaveChanges();
                return RedirectToAction("UserAddressList");
            }
            return View(useraddresses);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var UserAddresses = _context.UserAddresses.Find(Id);
            if (UserAddresses != null)
            {
                return View(UserAddresses);
            }
            return View(UserAddresses);
        }


    }
}

