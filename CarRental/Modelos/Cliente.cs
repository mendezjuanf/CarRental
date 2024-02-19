namespace CarRental.Modelos
{
    public class Cliente
    {
        public required String Id { get; set; }
        public required String Nombre { get; set; }
        public required String Email { get; set; }
        public required String Telefono { get; set; }
        public required List<Ciudad> Ciudad { get; set; }

    }
}
