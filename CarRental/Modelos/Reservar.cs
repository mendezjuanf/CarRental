using CarRental.Metodos;

namespace CarRental.Modelos
{
    public class Reservar
    {
        public required int Id { get; set; }
        public required Cliente ClienteId { get; set; }
        public required Vehiculo VehiculoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }
    }
}
