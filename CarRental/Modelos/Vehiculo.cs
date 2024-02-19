using CarRental.Modelos;

namespace CarRental.Metodos
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public required String Marca { get; set; }
        public required String Modelo { get; set; }
        public int Año { get; set; }
        public required String Color { get; set; }
        public bool Disponible { get; set; }
        public required Local LocalId { get; set; }

    }
}
