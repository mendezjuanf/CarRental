namespace CarRental.Modelos
{
    public class Local
    {
        public required int Id { get; set; }
        public required String Nombre { get; set; }
        public required String Direccion { get; set; }
        public required String Telefono { get; set; }
        public required DateTime HoraInicio { get; set; }
        public required DateTime HoraCierre { get; set; }
        public required Ciudad CiudadId { get; set; }

    }


}
