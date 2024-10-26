using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using Online_Grocey.Models;

namespace Online_Grocery.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly GroceryDbContext _context;
        //constructor
        public OrderDetailController(GroceryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            IEnumerable<OrderDetail> list = _context.OrderDetails;
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(OrderDetail orderdetails)
        {
            if (ModelState.IsValid)
            {
                _context.OrderDetails.Add(orderdetails);
                _context.SaveChanges();
                return RedirectToAction("OrderDetailList");
            }


            return View(orderdetails);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var OrderDetails = _context.OrderDetails.Find(Id);
            if (OrderDetails != null)
            {
                return View(OrderDetails);
            }
            return View(OrderDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            var OrderDetails = await _context.OrderDetails.FindAsync(Id);
            if (OrderDetails != null)
            {
                _context.OrderDetails.Remove(OrderDetails);
                _context.SaveChanges();
                return RedirectToAction("OrderDetailList");
            }

            return RedirectToAction("OrderDetailList");

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var OrderDetails = _context.OrderDetails.Find(Id);
            if (OrderDetails != null)
            {
                return View(OrderDetails);
            }
            return View(OrderDetails);
        }
        [HttpPost]
        public IActionResult Edit(OrderDetail orderdetails)
        {
            if (ModelState.IsValid)
            {
                _context.OrderDetails.Update(orderdetails);
                _context.SaveChanges();
                return RedirectToAction("OrderDetailList");
            }
            return View(orderdetails);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) { return NotFound(); }
            var OrderDetails = _context.OrderDetails.Find(Id);
            if (OrderDetails != null)
            {
                return View(OrderDetails);
            }
            return View(OrderDetails);
        }


    }
}

