using System;

namespace HallEase.SourceCode.Models
{
    /// <summary>
    /// كلاس لتمثيل بيانات الحجز (Booking).
    /// </summary>
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int HallID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; } // "Pending", "Confirmed", "Cancelled"
    }
}
