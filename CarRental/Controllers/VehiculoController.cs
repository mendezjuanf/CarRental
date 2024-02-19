using CarRental.Metodos;
using CarRental.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class VehiculoController : Controller
    {
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();

        [HttpGet("verVehiculos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Vehiculo>> GetVehiculos()
        {
            return Ok(vehiculos);
        }

        [HttpPost("addVehiculo")]
        public IActionResult AgregarLocal([FromBody] Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
            return Ok(vehiculo);
        }
    }
}
