using System;

namespace HallsProjects
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "Owner", "Customer"
    }

    public class Hall
    {
        public int HallID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int OwnerID { get; set; }
    }

    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int HallID { get; set; }
        public DateTime BookingDate { get; set; }
        public string PaymentStatus { get; set; } // "Paid", "Not Paid"
        public string BookingStatus { get; set; } // "Pending", "Confirmed", "Cancelled"

        // Additional properties for display purposes (joined data)
        public string HallName { get; set; }
        public string CustomerName { get; set; }
    }
}