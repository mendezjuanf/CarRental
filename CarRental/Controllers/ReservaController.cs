using CarRental.Datos;
using CarRental.Metodos;
using CarRental.Modelos;
using CarRental.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase 
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();
        private static List<Reservar> reservas = new List<Reservar>();

        [HttpGet("disponibles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult ObtenerVehiculosDisponibles(int localRecoger, int idCliente)
        {
        
            var vehiculosDisponibles = vehiculos
                .Where(v =>v.LocalId.Id == localRecoger && v.Disponible==true).ToList();
          
            return Ok(vehiculosDisponibles);
        }

        [HttpPost("Reservar")]
        public IActionResult AgregarLocal([FromBody] Reservar reserva)
        {
            var vehiculo = vehiculos.FirstOrDefault(v => v.Id == reserva.VehiculoId.Id);
            reservas.Add(reserva);
            vehiculo.Disponible = false;

            return Ok(reserva);
        }

    }
}
