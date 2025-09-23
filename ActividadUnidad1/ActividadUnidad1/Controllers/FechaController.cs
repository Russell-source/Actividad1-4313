using Microsoft.AspNetCore.Mvc;
using System;

namespace TuProyecto.Controllers
{
    public class FechaController : Controller
    {
        public IActionResult DiaSemana(DateTime? fecha)
        {
            if (fecha == null)
            {
                ViewBag.Mensaje = "Por favor ingresa una fecha.";
            }
            else
            {
                string dia = fecha.Value.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));
                ViewBag.Mensaje = $"La fecha {fecha:yyyy-MM-dd} corresponde al día: {dia}.";
            }

            return View();
        }
    }
}

