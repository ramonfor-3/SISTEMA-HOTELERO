namespace SISTEMA_HOTELERO.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }

        public Property Property { get; set; }
    }

}
