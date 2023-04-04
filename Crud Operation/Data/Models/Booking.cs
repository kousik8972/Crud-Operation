using System;

namespace Crud_Operation.Data.Models
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
