using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Areas.Admin.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ProductService _productservice;

        public ProductsController()
        {
            _productservice = new ProductService();

        }
        public IActionResult Index()
        {
            List<Product> products = _productservice.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Info(int id)
        {
            Product product = _productservice.GetProductById(id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productservice.CreateProduct(product);

            return RedirectToAction(nameof(Create));
        }

        [HttpGet]
        public IActionResult Delete(int id) {

            _productservice.Delete(id);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult Update(int id) {
            var model = _productservice.GetProductById(id);
            return View(model); 
        }

        [HttpPost]
        public IActionResult Update(int id,Product product) {

            _productservice.Update(id,product);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
