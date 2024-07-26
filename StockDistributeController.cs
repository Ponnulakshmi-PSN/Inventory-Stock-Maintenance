using Microsoft.AspNetCore.Mvc;

namespace InventoryStockMaintenance.WepApplication.Controllers
{
    public class StockDistributeController : Controller
    {
        public IActionResult StockDistribution()
        {
            return View();
        }
    }
}
