using Microsoft.AspNetCore.Identity;

namespace SISTEMA_HOTELERO.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; } 

        public IdentityUser User { get; set; }
        public Property Property { get; set; }
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }

}
