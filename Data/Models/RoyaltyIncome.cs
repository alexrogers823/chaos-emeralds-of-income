using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class RoyaltyIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Frequency { get; set; }
        public double Amount { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}