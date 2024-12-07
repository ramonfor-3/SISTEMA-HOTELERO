using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISTEMA_HOTELERO.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public PropertyStatus Status { get; set; }
        public IdentityUser Owner { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }

    public enum PropertyStatus
    {
        Available,
        Reserved,
        Maintenance
    }

}
