using CarVillaProject.BL.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;


namespace CarVillaProject.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarService _carser;
        public HomeController()
        {
            _carser = new CarService();
        }

        public IActionResult Index()
        {

            return View(_carser.GetAllCars());
        }
    }
}
