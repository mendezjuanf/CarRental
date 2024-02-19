using CarRental.Metodos;
using CarRental.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CiudadController : Controller
    {
        private static List<Ciudad> ciudades = new List<Ciudad>();

        [HttpGet("verCiudades")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Ciudad>> GetCiudades()
        {
            return Ok(ciudades);
        }

        [HttpPost("addCiudades")]
        public IActionResult AgregarLocal([FromBody] Ciudad ciudad)
        {
            ciudades.Add(ciudad);
            return Ok(ciudad);
        }
    }
}
