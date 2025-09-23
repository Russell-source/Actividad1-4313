using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TuProyecto.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult Tabla()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tabla(int numero)
        {
            var tabla = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                tabla.Add($"{numero} x {i} = {numero * i}");
            }

            ViewBag.Numero = numero;
            ViewBag.Tabla = tabla;

            return View();
        }
    }
}



