using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;

            ViewBag.Fahrenheit = fahrenheit;
            ViewBag.Celsius = celsius;

            return View();
        }
    }
}

