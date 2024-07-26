using Microsoft.AspNetCore.Mvc;

namespace InventoryStockMaintenance.WepApplication.Controllers
{
    public class DistributerController : Controller
    {
        public IActionResult Distributer()
        {
            return View();
        }
    }
}
