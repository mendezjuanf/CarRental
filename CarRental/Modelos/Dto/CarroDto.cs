namespace CarRental.Modelos.Dto
{
    public class CarroDto
    {
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public int Año{ get; set;}
        public required string Color { get; set; }
        public bool Disponible { get; set; }

    }
}
