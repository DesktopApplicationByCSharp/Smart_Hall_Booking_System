using HallsProjects;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public class BookingService
    {
        public bool CreateBooking(Booking booking)
        {
            string query = @"INSERT INTO Bookings (UserID, HallID, BookingDate, PaymentStatus, BookingStatus) 
                             VALUES (@UserID, @HallID, @BookingDate, @PaymentStatus, @BookingStatus)";

            SqlParameter[] parameters = {
                new SqlParameter("@UserID", booking.UserID),
                new SqlParameter("@HallID", booking.HallID),
                new SqlParameter("@BookingDate", booking.BookingDate),
                new SqlParameter("@PaymentStatus", booking.PaymentStatus),
                new SqlParameter("@BookingStatus", booking.BookingStatus ?? "Pending")
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CancelBooking(int bookingId)
        {
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
            SqlParameter[] parameters = { new SqlParameter("@BookingID", bookingId) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public (bool IsSuccess, string ErrorMessage) DeleteBooking(int bookingId)
        {
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
            SqlParameter[] parameters = { new SqlParameter("@BookingID", bookingId) };
            if (DatabaseHelper.TryExecuteNonQuery(query, parameters, out string errorMessage))
            {
                return (true, null);
            }
            return (false, errorMessage);
        }

        public DataTable GetBookingsByUser(int userId)
        {
            string query = @"SELECT b.BookingID, h.Name AS HallName, u.Name AS CustomerName, b.BookingDate, b.PaymentStatus, b.BookingStatus 
                             FROM Bookings b 
                             JOIN Halls h ON b.HallID = h.HallID 
                             JOIN Users u ON b.UserID = u.UserID 
                             WHERE b.UserID = @UserID";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetBookingsByOwner(int ownerId)
        {
            string query = @"SELECT b.BookingID, h.Name AS HallName, u.Name AS CustomerName, b.BookingDate, b.PaymentStatus, b.BookingStatus 
                             FROM Bookings b 
                             JOIN Halls h ON b.HallID = h.HallID 
                             JOIN Users u ON b.UserID = u.UserID 
                             WHERE h.OwnerID = @OwnerID";
            SqlParameter[] parameters = { new SqlParameter("@OwnerID", ownerId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllBookings() 
        {
            string query = @"SELECT b.BookingID, h.Name AS HallName, u.Name AS CustomerName, b.BookingDate, b.PaymentStatus, b.BookingStatus 
                             FROM Bookings b 
                             JOIN Halls h ON b.HallID = h.HallID 
                             JOIN Users u ON b.UserID = u.UserID";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetBookingsByCustomer(int customerId)
        {
            // Alias kept for UI naming; same as GetBookingsByUser
            return GetBookingsByUser(customerId);
        }
    }
}