namespace FOLYFOOD.Entitys
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public int NumberOfPeopleBooked { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime appointmentDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Booking thuộc về một User
        public User User { get; set; }

        // Mối quan hệ: Một Booking có nhiều ReservationDetailsService
        public ICollection<ReservationDetailsService> ReservationDetailsServices { get; set; }

        // Mối quan hệ: Một Booking có một Payment
        public Payment Payment { get; set; }
    }
}
