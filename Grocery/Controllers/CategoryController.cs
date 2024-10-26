using Microsoft.AspNetCore.Mvc;

namespace Online_Grocery.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
