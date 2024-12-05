namespace SISTEMA_HOTELERO.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string Url { get; set; }

        public Property Property { get; set; }
    }

}
