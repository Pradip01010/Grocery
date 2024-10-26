using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class DiscountController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public DiscountController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> DiscountList()
        {
            IEnumerable<Discount> list = _context.Discounts;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Discount discounts)
        {
            if (ModelState.IsValid)
            {
                _context.Discounts.Add(discounts);
                _context.SaveChanges();
                return RedirectToAction("DiscountList");
            }


            return View(discounts);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Discounts = _context.Discounts.Find(Id);
            if (Discounts != null)
            {
                return View(Discounts);
            }
            return View(Discounts);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var Discounts = await _context.Discounts.FindAsync(Id);
            if (Discounts != null)
            {
                _context.Discounts.Remove(Discounts);
                _context.SaveChanges();
                return RedirectToAction("DiscountList");
            }

            return RedirectToAction("DiscountList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Discounts = _context.Discounts.Find(Id);
            if (Discounts != null)
            {
                return View(Discounts);
            }
            return View(Discounts);
        }
        [HttpPost]
        public IActionResult Edit(Discount discounts)
        {
            if (ModelState.IsValid)
            {
                _context.Discounts.Update(discounts);
                _context.SaveChanges();
                return RedirectToAction("DiscountList");
            }
            return View(discounts);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var Discounts = _context.Discounts.Find(Id);
            if (Discounts != null)
            {
                return View(Discounts);
            }
            return View(Discounts);
        }

    }
}

