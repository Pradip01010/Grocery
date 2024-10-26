using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class WishListController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public WishListController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> WishListList()
        {
            IEnumerable<WishList> list = _context.wishLists; ;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WishList wishlists)
        {
            if (ModelState.IsValid)
            {
                _context.wishLists.Add(wishlists);
                _context.SaveChanges();
                return RedirectToAction("WishListList");
            }


            return View(wishlists);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var wishList = _context.wishLists.Find(Id);
            if (wishList != null)
            {
                return View(wishList);
            }
            return View(wishList);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var wishLists = await _context.wishLists.FindAsync(Id);
            if (wishLists != null)
            {
                _context.wishLists.Remove(wishLists);
                _context.SaveChanges();
                return RedirectToAction("WishListList");
            }

            return RedirectToAction("WishListList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var wishLists = _context.wishLists.Find(Id);
            if (wishLists != null)
            {
                return View(wishLists);
            }
            return View(wishLists);
        }
        [HttpPost]
        public IActionResult Edit(WishList wishlists)
        {
            if (ModelState.IsValid)
            {
                _context.wishLists.Update(wishlists);
                _context.SaveChanges();
                return RedirectToAction("WishListList");
            }
            return View(wishlists);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var wishLists = _context.wishLists.Find(Id);
            if (wishLists != null)
            {
                return View(wishLists);
            }
            return View(wishLists);
        }

    }
}

