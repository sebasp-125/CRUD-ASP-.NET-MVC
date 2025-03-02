namespace Repository_Modelo.Models
{
    public class Shooping
    {

        public int Id { get; set; }  // ID de la compra
        public int IdUser { get; set; }  // ID del usuario que realiza la compra
        public int IdCar { get; set; }  // ID del carro comprado
        public DateTime FechaCompra { get; set; }  // Fecha y hora de la compra

    }
}
