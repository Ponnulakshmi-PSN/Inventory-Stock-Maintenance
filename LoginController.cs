using Microsoft.AspNetCore.Mvc;

namespace InventoryStockMaintenance.WepApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
