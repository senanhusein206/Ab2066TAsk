using CarVillaProject.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVillaProject.MVC.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController : Controller
{
    private readonly Car featuredCar;
    public DashboardController()
    {
        featuredCar = new Car();
    }
    public IActionResult Index()
    {
        return View();
    }
}
