using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class OperacionesController : Controller
    {
        public IActionResult Sumar(int a, int b)
        {
            int resultado = a + b;
            ViewBag.Operacion = "Suma";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public IActionResult Restar(int a, int b)
        {
            int resultado = a - b;
            ViewBag.Operacion = "Resta";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public IActionResult Multiplicar(int a, int b)
        {
            int resultado = a * b;
            ViewBag.Operacion = "Multiplicación";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public IActionResult Residuo(int a, int b)
        {
            int resultado = a % b;
            ViewBag.Operacion = "Residuo";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }
    }
}

