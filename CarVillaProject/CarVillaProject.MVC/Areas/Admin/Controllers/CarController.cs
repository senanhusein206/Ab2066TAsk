using CarVillaProject.BL.Services;
using CarVillaProject.BL.ViewModels;
using CarVillaProject.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVillaProject.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {
        private readonly CarService carService;
        public CarController()
        {
            carService = new CarService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            carService.GetAllCars();
            return View(carService.GetAllCars());
        }


        [HttpGet]
        public IActionResult Info(int id)
        {

            return View(carService.GetCArById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarCreateVM car)
        {
            carService.Create(car);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Car ftcar = carService.GetCArById(id);
            return View(ftcar);
        }

        [HttpPost]

        public IActionResult Update(int id, Car car)
        {
            carService.Update(id, car);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            carService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
