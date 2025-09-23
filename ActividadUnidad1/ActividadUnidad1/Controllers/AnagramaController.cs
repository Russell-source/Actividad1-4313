using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TuProyecto.Controllers
{
    public class AnagramaController : Controller
    {
        public IActionResult Verificar(string texto1, string texto2)
        {
            
            string limpio1 = new string(texto1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
            string limpio2 = new string(texto2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

            
            string ordenado1 = new string(limpio1.OrderBy(c => c).ToArray());
            string ordenado2 = new string(limpio2.OrderBy(c => c).ToArray());

           
            bool sonAnagramas = ordenado1 == ordenado2;

            ViewBag.Mensaje = sonAnagramas
                ? "¡Son anagramas!"
                : "No son anagramas.";

            return View();
        }
    }
}

