using System;

namespace CableTV.Db
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int CreatedBy { get; set; }

    }
}
