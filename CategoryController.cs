using Microsoft.AspNetCore.Mvc;

namespace InventoryStockMaintenance.WepApplication.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
