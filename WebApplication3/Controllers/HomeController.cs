using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexts;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _service;
        public HomeController()
        {
            _service = new ProductService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _service.GetAllProducts();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _service.CreateProduct(product);
            return View();

        }
    }
}
