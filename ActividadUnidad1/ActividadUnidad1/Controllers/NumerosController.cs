using Microsoft.AspNetCore.Mvc;

namespace DemoSigno.Controllers
{
    public class NumerosController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Signo(int? numero)
        {
            string resultado;

            if (!numero.HasValue)
                resultado = "No se ha ingresado ningún número.";
            else if (numero > 0)
                resultado = "El número es positivo.";
            else if (numero < 0)
                resultado = "El número es negativo.";
            else
                resultado = "El número es cero.";

            ViewBag.Resultado = resultado;
            return View();
        }
    }
}

