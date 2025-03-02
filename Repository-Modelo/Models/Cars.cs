namespace Repository_Modelo.Models
{
    public class Cars
    {
        public int Xid { get; set; }  // Asumí que "Xid" es el ID de la tabla
        public int Id { get; set; }  // ID del carro
        public string TypeCar { get; set; }  // Tipo de carro (Sedán, SUV, etc.)
        public string CarBrand { get; set; }  // Marca del carro (Toyota, Ford, etc.)
        public int MaxSpeed { get; set; }  // Velocidad máxima
        public int MinSpeed { get; set; }  // Velocidad mínima
        public int Price { get; set; }  // Precio del carro
        public int? IdUser { get; set; }  // ID del usuario (puede ser null si no está asignado)
    }
}
