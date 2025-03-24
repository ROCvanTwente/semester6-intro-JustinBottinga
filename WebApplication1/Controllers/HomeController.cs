using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_02;
using WebApplication1.Models;

public class HomeController : Controller
{
    private static Bike bike = new Bike(15, 2, "Red");
    private static Car car = new Car(50, 4, "Orange");

    public IActionResult Index()
    {
        var carBikeViewModel = new CarBikeViewModel
        {
            bike = bike,
            car = car
        };

        return View(carBikeViewModel);
    }

    public IActionResult SpeedUpCar()
    {
        return Content(car.SpeedUp());
    }

    public IActionResult SlowDownCar()
    {
        return Content(car.SlowDown());
    }

    public IActionResult PrintCar()
    {
        return Content(car.Print());
    }

    public IActionResult SpeedUpBike()
    {
        return Content(bike.SpeedUp());
    }

    public IActionResult SlowDownBike()
    {
        return Content(bike.SlowDown());
    }

    public IActionResult PrintBike()
    {
        return Content(bike.Print());
    }
}
