using Microsoft.AspNetCore.Mvc;

namespace aspDotNetWebAppMVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
