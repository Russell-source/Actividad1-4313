using Microsoft.AspNetCore.Mvc;

namespace ContadorDeVocales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OracionController : ControllerBase
    {
        [HttpGet("ContarVocales")]
        public IActionResult ContarVocales(string frase)
        {
            if (string.IsNullOrWhiteSpace(frase))
            {
                return BadRequest("La frase no puede estar vacía.");
            }

            int cantidadVocales = frase.Count(c => "aeiouAEIOU".Contains(c));

            return Ok(new { Frase = frase, Vocales = cantidadVocales });
        }
    }
}

