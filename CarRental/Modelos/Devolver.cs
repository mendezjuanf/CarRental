using CarRental.Metodos;

namespace CarRental.Modelos
{
    public class Devolver
    {
        public required Reservar ReservaId { get; set; }
        public required DateTime FechaDevolucion { get; set; }
    }
}
