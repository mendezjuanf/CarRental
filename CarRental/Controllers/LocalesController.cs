using CarRental.Datos;
using CarRental.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class LocalesController : Controller
    {
        private static List<Local> locales = new List<Local>();

        [HttpGet("verLocales")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Local>> GetLocales()
        {
            return Ok(locales);
        }

        [HttpPost("addlocal")]
        public IActionResult AgregarLocal([FromBody] Local local)
        {
            locales.Add(local);
            return Ok(local);
        }


    }
}
