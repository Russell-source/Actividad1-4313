using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class PrimoController : Controller
    {
        public IActionResult Verificar(int? numero)
        {
            if (numero == null)
            {
                ViewBag.Mensaje = "Por favor ingresa un número.";
            }
            else
            {
                bool esPrimo = EsPrimo(numero.Value);
                ViewBag.Mensaje = esPrimo
                    ? $"{numero} es un número primo."
                    : $"{numero} no es un número primo.";
            }

            return View();
        }

        private bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}

