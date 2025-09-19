using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TuProyecto.Controllers
{
    public class NumeroController : Controller
    {
        // Acción GET: muestra el formulario
        [HttpGet]
        public IActionResult Tabla()
        {
            return View();
        }

        // Acción POST: recibe el número y genera la tabla
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



