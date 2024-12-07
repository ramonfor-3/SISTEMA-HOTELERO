using Microsoft.AspNetCore.Identity;

namespace SISTEMA_HOTELERO.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }

        public IdentityUser User { get; set; }
        public Property Property { get; set; }
    }

}
