using Microsoft.AspNetCore.Mvc;

namespace InventoryStockMaintenance.WepApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Stock()
        {
            return View();
        }
    }
}
