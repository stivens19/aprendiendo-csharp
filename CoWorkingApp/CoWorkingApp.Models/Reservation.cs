using System;
namespace CoWorkingApp.Models
{
    public class Reservation
    {
        public Guid ReservationId { get; set; }
        public DateTime ReservationDate { get; set; }
        public Guid UserId { get; set; }
        public Guid DeskId { get; set; }
    }
}