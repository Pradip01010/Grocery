using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class CustomerReviewController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public CustomerReviewController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> CustomerReviewList()
        {
            IEnumerable<CustomerReview> list = _context.CustomerReviews;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerReview customerreviews)
        {
            if (ModelState.IsValid)
            {
                _context.CustomerReviews.Add(customerreviews);
                _context.SaveChanges();
                return RedirectToAction("CustomerReviewList");
            }

            return View(customerreviews);
        }

        [HttpGet]

        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var CustomerReviews = _context.CustomerReviews.Find(Id);
            if (CustomerReviews != null)
            {
                return View(CustomerReviews);
            }
            return View(CustomerReviews);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var CustomerReviews = await _context.CustomerReviews.FindAsync(Id);
            if (CustomerReviews != null)
            {
                _context.CustomerReviews.Remove(CustomerReviews);
                _context.SaveChanges();
                return RedirectToAction("CustomerReviewList");
            }

            return RedirectToAction("CustomerReviewList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var CustomerReviews = _context.CustomerReviews.Find(Id);
            if (CustomerReviews != null)
            {
                return View(CustomerReviews);
            }
            return View(CustomerReviews);
        }
        [HttpPost]
        public IActionResult Edit(CustomerReview customerreviews)
        {
            if (ModelState.IsValid)
            {
                _context.CustomerReviews.Update(customerreviews);
                _context.SaveChanges();
                return RedirectToAction("CustomerReviewList");
            }
            return View(customerreviews);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var CustomerReviews = _context.CustomerReviews.Find(Id);
            if (CustomerReviews != null)
            {
                return View(CustomerReviews);
            }
            return View(CustomerReviews);
        }

    }
}

  
    

