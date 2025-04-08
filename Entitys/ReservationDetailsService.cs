using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("Reservation_details_service")]
    public class ReservationDetailsService
    {
        public int ReservationDetailsServiceId { get; set; }
        public int ServiceId { get; set; }
        public int BookingId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một ReservationDetailsService thuộc về một Service
        public Service Service { get; set; }

        // Mối quan hệ: Một ReservationDetailsService thuộc về một Booking
        public Booking Booking { get; set; }
    }
}
