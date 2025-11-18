using System;

namespace HallEase.SourceCode.Models
{
    /// <summary>
    /// كلاس لتمثيل بيانات المستخدم (User).
    /// </summary>
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; } // "Admin" or "User"
    }
}
