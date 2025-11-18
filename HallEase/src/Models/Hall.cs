using System;

namespace HallEase.SourceCode.Models
{
    /// <summary>
    /// كلاس لتمثيل بيانات القاعة (Hall).
    /// </summary>
    public class Hall
    {
        public int HallID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
