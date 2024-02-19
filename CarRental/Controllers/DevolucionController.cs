using CarRental.Metodos;
using CarRental.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class DevolucionController : Controller
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();
        private static List<Reservar> reservas = new List<Reservar>();

        [HttpPost]
        public IActionResult DevolverVehiculo(int idReserva)
        {
            if (idReserva ==  0)
            {
                return NotFound("No se encontró el vehículo.");
            } 
            else { 
                var reserva = reservas.FirstOrDefault(r => r.Id == idReserva);
                var vehiculo = vehiculos.FirstOrDefault(v => v.Id == reserva.VehiculoId.Id);

                    if (vehiculo == null)
                    {
                        return NotFound("No se encontró el vehículo.");
                    }

                    if (!vehiculo.Disponible)
                    {
                        return BadRequest("El vehículo no está rentado.");
                    }

                        vehiculo.Disponible = true;

                        return Ok($"Vehículo {vehiculo.Id} devuelto con éxito.");
            }
        }
    }
}
