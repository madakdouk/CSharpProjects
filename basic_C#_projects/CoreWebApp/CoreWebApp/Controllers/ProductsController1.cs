using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
