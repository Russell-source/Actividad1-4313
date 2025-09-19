using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TuProyecto.Controllers
{
    public class AnagramaController : Controller
    {
        public IActionResult Verificar(string texto1, string texto2)
        {
            // Normalizar los textos: quitar espacios y convertir a minúsculas
            string limpio1 = new string(texto1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
            string limpio2 = new string(texto2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

            // Ordenar los caracteres
            string ordenado1 = new string(limpio1.OrderBy(c => c).ToArray());
            string ordenado2 = new string(limpio2.OrderBy(c => c).ToArray());

            // Comparar
            bool sonAnagramas = ordenado1 == ordenado2;

            ViewBag.Mensaje = sonAnagramas
                ? "¡Son anagramas!"
                : "No son anagramas.";

            return View();
        }
    }
}

