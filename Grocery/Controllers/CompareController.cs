using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class CompareController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public CompareController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> CompareList()
        {
            IEnumerable<Compare> list = _context.Compares;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Compare compares)
        {
            if (ModelState.IsValid)
            {
                _context.Compares.Add(compares);
                _context.SaveChanges();
                return RedirectToAction("EventList");
            }


            return View(compares);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Compares = _context.Compares.Find(Id);
            if (Compares != null)
            {
                return View(Compares);
            }
            return View(Compares);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var Compares = await _context.Compares.FindAsync(Id);
            if (Compares != null)
            {
                _context.Compares.Remove(Compares);
                _context.SaveChanges();
                return RedirectToAction("CompareList");
            }

            return RedirectToAction("CompareList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Compares = _context.Compares.Find(Id);
            if (Compares != null)
            {
                return View(Compares);
            }
            return View(Compares);
        }
        [HttpPost]
        public IActionResult Edit(Compare compares)
        {
            if (ModelState.IsValid)
            {
                _context.Compares.Update(compares);
                _context.SaveChanges();
                return RedirectToAction("CompareList");
            }
            return View(compares);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var Compares = _context.Compares.Find(Id);
            if (Compares != null)
            {
                return View(Compares);
            }
            return View(Compares);
        }

    }
}

   
    

