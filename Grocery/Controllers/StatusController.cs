using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class StatusController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public StatusController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> StatusList()
        {
            IEnumerable<Status> list = _context.Statuses;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Status status)
        {
            if (ModelState.IsValid)
            {
                _context.Statuses.Add(status);
                _context.SaveChanges();
                return RedirectToAction("StatusList");
            }


            return View(status);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Statuses = _context.Statuses.Find(Id);
            if (Statuses != null)
            {
                return View(Statuses);
            }
            return View(Statuses);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var Statuses = await _context.Statuses.FindAsync(Id);
            if (Statuses != null)
            {
                _context.Statuses.Remove(Statuses);
                _context.SaveChanges();
                return RedirectToAction("StatusList");
            }

            return RedirectToAction("StatusList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Statuses = _context.Statuses.Find(Id);
            if (Statuses != null)
            {
                return View(Statuses);
            }
            return View(Statuses);
        }
        [HttpPost]
        public IActionResult Edit(Status statuses)
        {
            if (ModelState.IsValid)
            {
                _context.Statuses.Update(statuses);
                _context.SaveChanges();
                return RedirectToAction("StatusList");
            }
            return View(statuses);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var Statuses = _context.Statuses.Find(Id);
            if (Statuses != null)
            {
                return View(Statuses);
            }
            return View(Statuses);
        }

    }
}

