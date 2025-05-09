using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        ProductService  _productservice;

        public DashboardController()
        {
            _productservice = new ProductService();

        }
        public IActionResult Index()
        {
            List<Product> products = _productservice.GetAllProducts();
            return View(products);
        }

   
    }
}
