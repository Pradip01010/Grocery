
using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Grocey.Models;

namespace Online_Grocey.Controllers
{
    public class CartController : Controller
    {
        private readonly GroceryDbContext _context;

        //constructor
        public CartController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> CartList()
        {
            // Asynchronously retrieve the list of carts from the database
            var list = await _context.Carts.ToListAsync();

            // Pass the list to the view
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cart carts)
        {
            if (ModelState.IsValid)
            {
                _context.Carts.Add(carts);
                _context.SaveChanges();
                return RedirectToAction("CartList");
            }


            return View(carts);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Carts = _context.Carts.Find(Id);
            if (Carts != null)
            {
                return View(Carts);
            }
            return View(Carts);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var Carts = await _context.Carts.FindAsync(Id);
            if (Carts != null)
            {
                _context.Carts.Remove(Carts);
                _context.SaveChanges();
                return RedirectToAction("CartList");
            }

            return RedirectToAction("CartList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Carts = _context.Carts.Find(Id);
            if (Carts != null)
            {
                return View(Carts);
            }
            return View(Carts);
        }
        [HttpPost]
        public IActionResult Edit(Cart carts)
        {
            if (ModelState.IsValid)
            {
                _context.Carts.Update(carts);
                _context.SaveChanges();
                return RedirectToAction("CartList");
            }
            return View(carts);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var Carts = _context.Carts.Find(Id);
            if (Carts != null)
            {
                return View(Carts);
            }
            return View(Carts);
        }
    }
}






